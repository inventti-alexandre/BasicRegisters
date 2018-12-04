using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Base.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades.Contas.Builder
{
    public class ContaBuilder : IBaseBuilder<ContaBuilder, Conta>
    {
        public string Apelido { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public DateTime? DataDeExclusao { get; private set; }
        public bool? Excluido { get; private set; }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario UsuarioDeCadastro { get; private set; }

        public virtual Usuario UsuarioDeExlusao { get; private set; }

        public Conta Build()
        {
            return new Conta(Id, Apelido, Nome, Ativo, DataDeCadastro, DataDeExclusao, Excluido);
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

        public ContaBuilder WithDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
            return this;
        }

        public ContaBuilder WithDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = dataDeExclusao;
            return this;
        }

        public ContaBuilder WithExcluido(bool? excluido)
        {
            Excluido = excluido ?? DataDeExclusao.HasValue;
            return this;
        }

        public ContaBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public ContaBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ContaBuilder WithUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = UsuarioDeCadastro;
            return this;
        }

        public ContaBuilder WithUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = usuarioDeExlusao;
            return this;
        }
    }
}