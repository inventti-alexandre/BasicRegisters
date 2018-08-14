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
    }
}