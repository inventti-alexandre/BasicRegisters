using AutoMapper;
using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Contas.Builder;
using BasicRegisters.Domain.Entidades.Usuarios.Builder;
using EFGetStarted.AspNetCore.NewDb.Models;
using NETCore.Encrypt;
using System;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public class DadosIniciaisServices : IDadosIniciaisServices
    {
        private readonly BasicRegistersContext _context;
        private readonly IMapper _mapper;

        public DadosIniciaisServices(BasicRegistersContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Tuple<ContaDto, UsuarioDto> GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto)
        {
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

            var contaDto = _mapper.Map<Conta, ContaDto>(conta);
            var usuarioDto = _mapper.Map<Usuario, UsuarioDto>(usuario);

            return new Tuple<ContaDto, UsuarioDto>(contaDto, usuarioDto);
        }
    }
}