using System;

namespace BasicRegisters.Domain.Entidades.Base.Interfaces
{
    public interface IBaseBuilder<T, E>
    {
        Guid Id { get; }
        bool Ativo { get; }
        DateTime DataDeCadastro { get; }
        DateTime? DataDeExclusao { get; }
        bool? Excluido { get; }

        E Build();

        T WithId(Guid id);

        T WithAtivo(bool ativo);

        T WithDataDeCadastro(DateTime dataDeCadastro);

        T WithDataDeExclusao(DateTime? dataDeExclusao);

        T WithExcluido(bool? excluido);
    }
}