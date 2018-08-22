using AutoMapper;
using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Contas.Builder;
using BasicRegisters.Domain.Entidades.Usuarios.Builder;
using EFGetStarted.AspNetCore.NewDb.Models;
using FluentValidation;
using FluentValidation.Results;
using NETCore.Encrypt;

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

        public GerarDadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto)
        {
            var validationResult = _dadosIniciaisValidator.Validate(dadosIniciaisDto);
            var gerarDadosIniciaisDto = new GerarDadosIniciaisDto();

            if (!validationResult.IsValid) return RegistrarErros(gerarDadosIniciaisDto, validationResult);

            var conta = new ContaBuilder()
                .WithApelido(dadosIniciaisDto.ApelidoDaConta)
                .WithAtivo(true)
                .WithNome(dadosIniciaisDto.NomeDaConta)
                .Build();

            var usuario = new UsuarioBuilder()
                .WithAdministradorDaConta(true)
                .WithApelido(dadosIniciaisDto.ApelidoParaUsuarioAdministrador)
                .WithAtivo(true)
                .WithEmail(dadosIniciaisDto.EmailParaUsuarioAdministrador)
                .WithConta(conta)
                .WithSenha(EncryptProvider.Md5(dadosIniciaisDto.SenhaParaUsuarioAdministrador))
                .Build();

            _context.Contas.Add(conta);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            gerarDadosIniciaisDto.ContaDto = _mapper.Map<Conta, ContaDto>(conta);
            gerarDadosIniciaisDto.UsuarioDto = _mapper.Map<Usuario, UsuarioDto>(usuario);

            gerarDadosIniciaisDto.IsValid = true;
            return gerarDadosIniciaisDto;
        }

        public GerarDadosIniciaisDto RegistrarErros(GerarDadosIniciaisDto gerarDadosIniciaisDto, ValidationResult validationResult)
        {
            gerarDadosIniciaisDto.Errors = validationResult.Errors;
            gerarDadosIniciaisDto.IsValid = validationResult.IsValid;
            return gerarDadosIniciaisDto;
        }
    }
}