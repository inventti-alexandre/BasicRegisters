using BasicRegisters.Domain.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IBaseEntidade
    {
        bool Ativo { get; set; }
        DateTime DataDeCadastro { get; set; }
        DateTime DataDeExclusao { get; set; }
        bool Excluido { get; set; }
        Guid Id { get; set; }

        [NotMapped]
        User UsuarioDeCadastro { get; set; }

        Guid UsuarioDeCadastroId { get; set; }

        [NotMapped]
        User UsuarioDeExlusao { get; set; }

        Guid UsuarioDeExlusaoId { get; set; }
    }
}