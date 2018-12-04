using BasicRegisters.Domain.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Entidades.Base
{
    public abstract class AbstractBaseEntity
    {
        public bool Ativo { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public DateTime? DataDeExclusao { get; private set; }
        public bool? Excluido { get; private set; }

        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("UsuarioDeCadastroId")]
        public Usuario UsuarioDeCadastro { get; private set; }

        public Guid? UsuarioDeCadastroId { get; private set; }

        [ForeignKey("UsuarioDeExlusaoId")]
        public virtual Usuario UsuarioDeExlusao { get; private set; }

        public Guid? UsuarioDeExlusaoId { get; private set; }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }

        public void SetDataDeCadastro(DateTime dataDeCadastro)
        {
            DataDeCadastro = dataDeCadastro;
        }

        public void SetDataDeExclusao(DateTime? dataDeExclusao)
        {
            DataDeExclusao = dataDeExclusao;
        }

        public void SetExcluido(bool? excluido)
        {
            Excluido = excluido ?? DataDeExclusao.HasValue;
        }

        public void SetId(Guid id)
        {
            Id = id;
        }

        public void SetUsuarioDeCadastro(Usuario usuarioDeCadastro)
        {
            UsuarioDeCadastro = usuarioDeCadastro;
            if (UsuarioDeCadastro != null) UsuarioDeCadastroId = UsuarioDeCadastro.Id;
        }

        public void SetUsuarioDeExlusao(Usuario usuarioDeExlusao)
        {
            UsuarioDeExlusao = usuarioDeExlusao;
            if (UsuarioDeExlusao != null) UsuarioDeExlusaoId = UsuarioDeExlusao.Id;
        }
    }
}