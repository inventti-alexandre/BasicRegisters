using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Base.Interfaces;
using BasicRegisters.Domain.Entidades.Contas;
using System;

namespace BasicRegisters.Domain.Entidades.Usuarios.Builder
{
    public class UsuarioBuilder : IBaseBuilder<UsuarioBuilder, Usuario>
    {
        public bool? AdministradorDaConta { get; private set; }
        public string Apelido { get; private set; }
        public bool Ativo { get; private set; }

        public virtual Conta Conta { get; private set; }
        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeExclusao { get; private set; }
        public string Email { get; private set; }
        public bool? Excluido { get; private set; }

        public Guid Id { get; private set; }

        public string Senha { get; private set; }
        public Usuario UsuarioDeCadastro { get; private set; }

        public virtual Usuario UsuarioDeExlusao { get; private set; }

        public Usuario Build()
        {
            return new Usuario(Id, AdministradorDaConta, Apelido, Email, Senha, Conta, Ativo, DataDeCadastro, DataDeExclusao, Excluido);
        }

        public UsuarioBuilder WithAdministradorDaConta(bool? administradorDaConta)
        {
            AdministradorDaConta = administradorDaConta;
            return this;
        }

        public UsuarioBuilder WithApelido(string apelido)
        {
            Apelido = apelido;
            return this;
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

        public UsuarioBuilder WithDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
            return this;
        }

        public UsuarioBuilder WithDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = dataDeExclusao;
            return this;
        }

        public UsuarioBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public UsuarioBuilder WithExcluido(bool? excluido)
        {
            Excluido = excluido ?? DataDeExclusao.HasValue;
            return this;
        }

        public UsuarioBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public UsuarioBuilder WithSenha(string senha)
        {
            Senha = senha;
            return this;
        }

        public UsuarioBuilder WithUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = usuarioDeCadastro;
            return this;
        }

        public UsuarioBuilder WithUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = usuarioDeExlusao;
            return this;
        }
    }
}