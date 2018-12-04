using BasicRegisters.Domain.Entidades.Pessoas;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades.Pessoas.Interfaces
{
    public interface IPessoaJuridica : IPessoa
    {
        [MaxLength(15)]
        string Cnpj { get; }
        [MaxLength(15)]
        string InscricaoEstadual { get; }
        [MaxLength(100)]
        string NomeFantasia { get; }
    }
}