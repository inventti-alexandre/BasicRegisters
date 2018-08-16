using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Interfaces;
using BasicRegisters.Domain.Telefones;
using System;

namespace BasicRegisters.Domain.Entidades.Telefones
{
    public interface ITelefone : IBaseEntidade<Telefone>
    {
        IConta Conta { get; set; }
        Guid ContaId { get; set; }
        string Numero { get; set; }
    }
}