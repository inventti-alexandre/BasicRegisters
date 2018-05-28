using System.Collections.Generic;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IPessoa : IBaseEntidade
    {
        string Nome { get; set; }
        List<Telefone> Telefones { get; set; }
    }
}