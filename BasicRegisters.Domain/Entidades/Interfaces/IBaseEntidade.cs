using BasicRegisters.Domain.Domain;
using System;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IBaseEntidade
    {
        bool Ativo { get; set; }
        DateTime DataDeCadastro { get; set; }
        DateTime? DataDeExclusao { get; set; }
        bool? Excluido { get; set; }
        Guid Id { get; set; }

        Usuario UsuarioDeCadastro { get; set; }

        Guid? UsuarioDeCadastroId { get; set; }

        Usuario UsuarioDeExlusao { get; set; }

        Guid? UsuarioDeExlusaoId { get; set; }
    }
}