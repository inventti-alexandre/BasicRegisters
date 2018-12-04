using BasicRegisters.Domain.Entidades.Base;
using BasicRegisters.Domain.Entidades.Base.Interfaces;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Pessoas.Interfaces;
using BasicRegisters.Domain.Telefones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Entidades.Pessoas
{
    public abstract class Pessoa : AbstractBaseEntity, IPessoa
    {
        public string Nome { get; private set; }

        public List<Telefone> Telefones { get; private set; }
        public string Discriminator { get; private set; }

        [ForeignKey("ContaId")]
        public Conta Conta { get; private set; }

        public Guid ContaId { get; private set; }
    }
}