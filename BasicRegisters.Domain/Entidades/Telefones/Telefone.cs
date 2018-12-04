using BasicRegisters.Domain.Entidades.Base;
using BasicRegisters.Domain.Entidades.Pessoas;
using BasicRegisters.Domain.Entidades.Telefones;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Telefones
{
    public class Telefone : AbstractBaseEntity, ITelefone
    {
        [MaxLength(20)]
        public string Numero { get; set; }
        public Pessoa Pessoa { get; private set; }
    }
}