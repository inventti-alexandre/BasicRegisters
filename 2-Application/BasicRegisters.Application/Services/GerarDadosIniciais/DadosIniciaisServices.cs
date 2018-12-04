using BasicRegisters.Application.Dtos_Genericos;
using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Contas.Builder;
using BasicRegisters.Domain.Entidades.Usuarios.Builder;
using AutoMapper;
using EFGetStarted.AspNetCore.NewDb.Models;
using FluentValidation;
using FluentValidation.Results;
using NETCore.Encrypt;
using System;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public class DadosIniciaisServices : IDadosIniciaisServices
    {
        private readonly BasicRegistersContext _context;
        private readonly IValidator<DadosIniciaisDto> _dadosIniciaisValidator;
        private readonly IMapper _mapper;

        public DadosIniciaisServices(BasicRegistersContext context, IMapper mapper, IValidator<DadosIniciaisDto> dadosIniciaisValidator)
        {
            _context = context;
            _mapper = mapper;
            _dadosIniciaisValidator = dadosIniciaisValidator;
        }

        public DadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto)
        {
            var validationResult = _dadosIniciaisValidator.Validate(dadosIniciaisDto);
            dadosIniciaisDto.Validar(_dadosIniciaisValidator);

            if (!dadosIniciaisDto.IsValid) return dadosIniciaisDto;
            var conta = new ContaBuilder()
                .WithApelido(dadosIniciaisDto.ApelidoDaConta)
                .WithAtivo(true)
                .WithNome(dadosIniciaisDto.NomeDaConta)
                .WithDataDeCadastro(DateTime.Now)
                .Build();

            var usuario = new UsuarioBuilder()
                .WithAdministradorDaConta(true)
                .WithApelido(dadosIniciaisDto.ApelidoParaUsuarioAdministrador)
                .WithAtivo(true)
                .WithEmail(dadosIniciaisDto.EmailParaUsuarioAdministrador)
                .WithConta(conta)
                .WithSenha(EncryptProvider.Md5(dadosIniciaisDto.SenhaParaUsuarioAdministrador))
                .WithDataDeCadastro(DateTime.Now)
                .Build();

            _context.Contas.Add(conta);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            var gerarDadosIniciaisDto = new GerarDadosIniciaisDto();
            gerarDadosIniciaisDto.ContaDto = _mapper.Map<Conta, ContaDto>(conta);
            gerarDadosIniciaisDto.UsuarioDto = _mapper.Map<Usuario, UsuarioDto>(usuario);

            return dadosIniciaisDto;
        }

        public BaseDto RegistrarErros(BaseDto dto, ValidationResult validationResult)
        {
            dto.Errors = validationResult.Errors;
            dto.IsValid = validationResult.IsValid;
            return dto;
        }
    }
}