using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades.Contas.Builder
{
    public class ContaBuilder : IBaseBuilder<ContaBuilder, Conta>
    {
        public string Apelido { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime? DataDeExclusao { get; private set; }
        public bool? Excluido { get; private set; }
        public string Nome { get; private set; }
        public Usuario UsuarioDeCadastro { get; private set; }
        public Usuario UsuarioDeExlusao { get; private set; }

        public Conta Build()
        {
            return new Conta(Apelido, Nome);
        }

        public ContaBuilder WithApelido(string apelido)
        {
            Apelido = apelido;
            return this;
        }

        public ContaBuilder WithAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public ContaBuilder WithDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = dataDeExclusao;
            return this;
        }

        public ContaBuilder WithExcluido(bool? excluido)
        {
            Excluido = excluido;
            return this;
        }

        public ContaBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ContaBuilder WithUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = usuarioDeCadastro;
            return this;
        }

        public ContaBuilder WithUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = usuarioDeExlusao;
            return this;
        }
    }
}