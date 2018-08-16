using BasicRegisters.Domain.Domain;
using System;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IBaseEntidade<T>
    {
        bool Ativo { get; }
        DateTime DataDeCadastro { get; }
        DateTime? DataDeExclusao { get; }
        bool? Excluido { get; }
        Guid Id { get; }

        Usuario UsuarioDeCadastro { get; }

        Guid? UsuarioDeCadastroId { get; }

        Usuario UsuarioDeExlusao { get; }

        Guid? UsuarioDeExlusaoId { get; }

        T SetAtivo(bool ativo);

        T SetDataDeCadastro(DateTime dataDeCadastro);

        T SetDataDeExclusao(DateTime? dataDeExclusao);

        T SetExcluido(bool? excluido);

        T SetId(Guid id);

        T SetUsuarioDeCadastro(Usuario usuarioDeCadastro);

        T SetUsuarioDeExlusao(Usuario usuarioDeExlusao);
    }
}