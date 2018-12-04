using BasicRegisters.Domain.Entidades.Pessoas;
using BasicRegisters.Domain.Entidades.Pessoas.Interfaces;

namespace BasicRegisters.Domain.Entidades
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public string NomeFantasia { get; private set; }
    }
}