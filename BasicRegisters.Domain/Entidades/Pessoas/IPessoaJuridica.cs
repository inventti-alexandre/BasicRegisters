using BasicRegisters.Domain.Entidades.Pessoas;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IPessoaJuridica : IPessoa
    {
        string Cnpj { get; set; }
        string InscricaoEstadual { get; set; }
        string NomeFantasia { get; set; }
    }
}