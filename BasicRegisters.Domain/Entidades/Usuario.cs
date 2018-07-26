using BasicRegisters.Domain.Entidades.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Domain
{
    public class Usuario : IUsuario
    {
        public string Apelido { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeExclusao { get; set; }
        public string Email { get; set; }
        public bool? Excluido { get; set; }
        public Guid Id { get; set; }
        public string Senha { get; set; }

        [NotMapped]
        public Usuario UsuarioDeCadastro { get; set; }

        [NotMapped]
        public Guid? UsuarioDeCadastroId { get; set; }

        [NotMapped]
        public Usuario UsuarioDeExlusao { get; set; }

        [NotMapped]
        public Guid? UsuarioDeExlusaoId { get; set; }
    }
}