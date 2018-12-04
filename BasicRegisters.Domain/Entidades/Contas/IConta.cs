namespace BasicRegisters.Domain.Entidades.Contas
{
    public interface IConta
    {
        string Apelido { get; }
        string Nome { get; }

        Conta SetApelido(string apelido);

        Conta SetNome(string nome);
    }
}