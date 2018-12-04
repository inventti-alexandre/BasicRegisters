using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades.Pessoas.Interfaces
{
    public interface IPessoaFisica : IPessoa
    {
        [MaxLength(15)]
        string Cpf { get; }

        DateTime DataNascimento { get; }

        [MaxLength(15)]
        string DocumentoDeIdentidade { get; }
    }
}