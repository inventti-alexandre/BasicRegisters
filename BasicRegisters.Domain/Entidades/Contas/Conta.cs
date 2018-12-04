using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public class Conta : AbstractBaseEntity, IConta
    {
        public Conta(Guid id, string apelido, string nome, bool ativo, DateTime dataDeCadastro, DateTime? dataDeExclusao, bool? excluido)
        {
            SetId(id);
            SetApelido(apelido);
            SetNome(nome);
            SetAtivo(true);
            SetDataDeCadastro(dataDeCadastro);
            SetDataDeExclusao(dataDeExclusao);
            SetExcluido(excluido);
        }

        public Conta()
        {
        }

        [MaxLength(20)]
        public string Apelido { get; private set; }

        public virtual Usuario Usuario { get; private set; }

        [MaxLength(80)]
        public string Nome { get; private set; }

        public Conta SetApelido(string apelido)
        {
            Apelido = apelido;
            return this;
        }

        public Conta SetNome(string nome)
        {
            Nome = nome;
            return this;
        }
    }
}