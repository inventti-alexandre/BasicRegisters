using BasicRegisters.Domain.Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public class Conta : IConta
    {
        public Conta(string apelido, string nome, Usuario usuarioDeCadastro)
        {
            SetApelido(apelido);
            SetNome(nome);
            DataDeCadastro = DateTime.Now;
            SetId(Guid.Empty);
            SetUsuarioDeCadastro(usuarioDeCadastro);
        }

        public string Apelido { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeExclusao { get; private set; }

        public bool? Excluido { get; private set; }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        [NotMapped]
        public Usuario UsuarioDeCadastro { get; private set; }

        public Guid? UsuarioDeCadastroId { get; private set; }

        [NotMapped]
        public Usuario UsuarioDeExlusao { get; private set; }

        public Guid? UsuarioDeExlusaoId { get; private set; }

        public Conta SetApelido(string apelido)
        {
            Apelido = apelido;
            return this;
        }

        public Conta SetAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public Conta SetDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
            return this;
        }

        public Conta SetDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = dataDeExclusao;
            return this;
        }

        public Conta SetExcluido(bool? excluido)
        {
            Excluido = excluido;
            return this;
        }

        public Conta SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public Conta SetNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Conta SetUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = usuarioDeCadastro;
            UsuarioDeCadastroId = usuarioDeCadastro.Id;
            return this;
        }

        public Conta SetUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = UsuarioDeExlusao;
            UsuarioDeExlusaoId = UsuarioDeExlusao.Id;
            return this;
        }
    }
}