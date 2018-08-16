using BasicRegisters.Domain.Entidades.Interfaces;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public interface IConta : IBaseEntidade<Conta>
    {
        string Apelido { get; }
        string Nome { get; }

        Conta SetApelido(string apelido);

        Conta SetNome(string nome);
    }
}