using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades.Usuarios.Builder
{
    public class UsuarioBuilder : IBaseBuilder<UsuarioBuilder, Usuario>
    {
        public UsuarioBuilder()
        {
        }

        public bool AdministradorDaConta { get; private set; }
        public string Apelido { get; private set; }
        public bool Ativo { get; private set; }
        public Conta Conta { get; private set; }

        public DateTime? DataDeExclusao { get; private set; }

        public string Email { get; private set; }
        public bool? Excluido { get; private set; }

        public string Senha { get; private set; }

        public Usuario Build()
        {
            return new Usuario(AdministradorDaConta, Apelido, Ativo, Email, Senha, Conta);
        }

        public UsuarioBuilder WithAdministradorDaConta(bool administradorDaConta)
        {
            AdministradorDaConta = administradorDaConta;
            return this;
        }

        public UsuarioBuilder WithApelido(string apelido)
        {
            Apelido = apelido;
            return this;
        }

        public object WithApelido(object apelidoParaUsuarioAdministrador)
        {
            throw new NotImplementedException();
        }

        public UsuarioBuilder WithAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public UsuarioBuilder WithConta(Conta conta)
        {
            Conta = conta;
            return this;
        }

        public UsuarioBuilder WithDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = DataDeExclusao;
            return this;
        }

        public UsuarioBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public UsuarioBuilder WithExcluido(bool? excluido)
        {
            Excluido = excluido;
            return this;
        }

        public UsuarioBuilder WithSenha(string senha)
        {
            Senha = senha;
            return this;
        }
    }
}