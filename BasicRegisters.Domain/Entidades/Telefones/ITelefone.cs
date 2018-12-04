using BasicRegisters.Domain.Entidades.Base.Interfaces;
using BasicRegisters.Domain.Telefones;

namespace BasicRegisters.Domain.Entidades.Telefones
{
    public interface ITelefone : IBaseEntidade<Telefone>
    {
        string Numero { get; }
    }
}