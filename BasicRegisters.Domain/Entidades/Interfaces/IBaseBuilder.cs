using System;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IBaseBuilder<T, E>
    {
        bool Ativo { get; }
        DateTime? DataDeExclusao { get; }
        bool? Excluido { get; }

        E Build();

        T WithAtivo(bool ativo);

        T WithDataDeExclusao(DateTime? dataDeExclusao);

        T WithExcluido(bool? excluido);
    }
}