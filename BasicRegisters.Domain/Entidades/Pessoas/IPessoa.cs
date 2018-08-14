using BasicRegisters.Domain.Entidades.Interfaces;
using BasicRegisters.Domain.Telefones;
using System.Collections.Generic;

namespace BasicRegisters.Domain.Entidades.Pessoas
{
    public interface IPessoa : IBaseEntidade
    {
        string Nome { get; set; }
        List<Telefone> Telefones { get; set; }
    }
}