using BasicRegisters.Domain.Entidades.Base.Interfaces;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Telefones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades.Pessoas.Interfaces
{
    public interface IPessoa : IBaseEntidade<Pessoa>
    {
        [MaxLength(100)]
        string Nome { get; }

        List<Telefone> Telefones { get; }

        [MaxLength(80)]
        string Discriminator { get; }

        Conta Conta { get; }
        Guid ContaId { get; }
    }
}