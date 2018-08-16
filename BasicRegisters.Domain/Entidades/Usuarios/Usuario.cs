using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Usuarios;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Domain
{
    public class Usuario : IUsuario
    {
        public string Apelido { get; set; }
        public bool Ativo { get; set; }
        public Conta Conta { get; set; }
        public Guid ContaId { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeExclusao { get; set; }
        public string Email { get; set; }
        public bool? Excluido { get; set; }
        public Guid Id { get; set; }
        public string Senha { get; set; }

        [NotMapped]
        public Usuario UsuarioDeCadastro { get; set; }

        public Guid? UsuarioDeCadastroId { get; set; }

        [NotMapped]
        public Usuario UsuarioDeExlusao { get; set; }

        public Guid? UsuarioDeExlusaoId { get; set; }

        public Usuario SetApelido(string apelido)
        {
            Apelido = apelido;
            return this;
        }

        public Usuario SetAtivo(bool ativo)
        {
            Ativo = ativo;
            return this;
        }

        public Usuario SetConta(Conta conta)
        {
            Conta = conta;
            ContaId = conta.Id;
            return this;
        }

        public Usuario SetDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
            return this;
        }

        public Usuario SetDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = DataDeExclusao;
            return this;
        }

        public Usuario SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public Usuario SetExcluido(bool? excluido)
        {
            Excluido = excluido;
            return this;
        }

        public Usuario SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public Usuario SetSenha(string senha)
        {
            Senha = senha;
            return this;
        }

        public Usuario SetUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = UsuarioDeCadastro;
            UsuarioDeCadastroId = UsuarioDeCadastro.Id;
            return this;
        }

        public Usuario SetUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = UsuarioDeExlusao;
            UsuarioDeExlusaoId = UsuarioDeCadastro.Id;
            return this;
        }
    }
}