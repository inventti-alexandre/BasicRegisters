using System;
using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;

namespace BasicRegisters.Domain.Entidades.Usuarios.Builder
{
    public class UsuarioBuilder : IBaseBuilder<UsuarioBuilder, Usuario>
    {
        public UsuarioBuilder()
        {
        }

        public bool Ativo { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeExclusao { get; private set; }

        public bool? Excluido { get; private set; }

        public Guid Id { get; private set; }

        public Usuario Build()
        {
            return new Usuario();
        }

        public UsuarioBuilder WithAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public UsuarioBuilder WithDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
            return this;
        }

        public UsuarioBuilder WithDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = DataDeExclusao;
            return this;
        }

        public UsuarioBuilder WithExcluido(bool? excluido)
        {
            Excluido = excluido;
            return this;
        }

        public UsuarioBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }
    }
}