using BasicRegisters.Domain.Entidades.Pessoas;
using BasicRegisters.Domain.Entidades.Pessoas.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string DocumentoDeIdentidade { get; private set; }
    }
}