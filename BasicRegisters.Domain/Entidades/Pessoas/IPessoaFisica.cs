using System;

namespace BasicRegisters.Domain.Entidades.Pessoas
{
    public interface IPessoaFisica : IPessoa
    {
        string Cpf { get; set; }
        DateTime DataNascimento { get; set; }
        string DocumentoDeIdentidade { get; set; }
    }
}