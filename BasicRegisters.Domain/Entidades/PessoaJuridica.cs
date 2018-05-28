using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades
{
    public class PessoaJuridica : IPessoaJuridica
    {
        public bool Ativo { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDeExclusao { get; set; }
        public bool Excluido { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string InscricaoEstadual { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public List<Telefone> Telefones { get; set; }
        public User UsuarioDeCadastro { get; set; }
        public Guid UsuarioDeCadastroId { get; set; }
        public User UsuarioDeExlusao { get; set; }
        public Guid UsuarioDeExlusaoId { get; set; }
    }
}