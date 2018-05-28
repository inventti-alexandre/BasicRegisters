namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IConta : IBaseEntidade
    {
        string Apelido { get; set; }
        string Nome { get; set; }
    }
}