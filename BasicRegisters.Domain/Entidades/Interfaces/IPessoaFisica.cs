using System;

namespace BasicRegisters.Domain.Entidades.Interfaces
{
    public interface IPessoaFisica : IPessoa
    {
        string Cpf { get; set; }
        DateTime DataNascimento { get; set; }
        string DocumentoDeIdentidade { get; set; }
    }
}