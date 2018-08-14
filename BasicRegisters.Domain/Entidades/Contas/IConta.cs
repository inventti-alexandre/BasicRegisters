using BasicRegisters.Domain.Entidades.Interfaces;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public interface IConta : IBaseEntidade
    {
        string Apelido { get; set; }
        string Nome { get; set; }
    }
}