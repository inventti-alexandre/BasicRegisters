using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Telefones;
using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Telefones
{
    public class Telefone : ITelefone
    {
        public bool Ativo { get; set; }
        public IConta Conta { get; set; }
        public Guid ContaId { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeExclusao { get; set; }
        public bool? Excluido { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string Numero { get; set; }
        public Usuario UsuarioDeCadastro { get; set; }
        public Guid? UsuarioDeCadastroId { get; set; }
        public Usuario UsuarioDeExlusao { get; set; }
        public Guid? UsuarioDeExlusaoId { get; set; }
    }
}