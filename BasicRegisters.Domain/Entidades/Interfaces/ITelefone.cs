using System;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface ITelefone : IBaseEntidade
    {
        IConta Conta { get; set; }
        Guid ContaId { get; set; }
        string Numero { get; set; }
    }
}