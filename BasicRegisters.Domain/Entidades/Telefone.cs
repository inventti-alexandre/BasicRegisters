using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades
{
    public class Telefone : ITelefone
    {
        public bool Ativo { get; set; }
        public IConta Conta { get; set; }
        public Guid ContaId { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDeExclusao { get; set; }
        public bool Excluido { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string Numero { get; set; }
        public User UsuarioDeCadastro { get; set; }
        public Guid UsuarioDeCadastroId { get; set; }
        public User UsuarioDeExlusao { get; set; }
        public Guid UsuarioDeExlusaoId { get; set; }
    }
}