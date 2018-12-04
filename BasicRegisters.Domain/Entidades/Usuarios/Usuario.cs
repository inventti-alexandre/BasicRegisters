using BasicRegisters.Domain.Entidades.Base;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Usuarios;
using System;
using System.ComponentModel.DataAnnotations;

namespace BasicRegisters.Domain.Domain
{
    public class Usuario : AbstractBaseEntity, IUsuario
    {
        public Usuario(Guid id,
            bool? administradorDaConta,
            string apelido,
            string email,
            string senha,
            Conta conta,
            bool ativo,
            DateTime dataDeCadastro,
            DateTime? dataDeExclusao,
            bool? excluido)
        {
            SetId(id);
            SetAdministradorDaConta(administradorDaConta);
            SetApelido(apelido);
            SetEmail(email);
            SetSenha(senha);
            SetConta(conta);
            SetAtivo(ativo);
            SetDataDeCadastro(dataDeCadastro);
            SetDataDeExclusao(dataDeExclusao);
            SetExcluido(excluido);
        }

        public Usuario()
        {
        }

        public bool? AdministradorDaConta { get; private set; }

        [MaxLength(80)]
        public string Apelido { get; private set; }

        public virtual Conta Conta { get; private set; }

        public Guid ContaId { get; private set; }

        [MaxLength(120)]
        public string Email { get; private set; }

        public string Senha { get; private set; }

        public void SetAdministradorDaConta(bool? administradorDaConta)
        {
            AdministradorDaConta = administradorDaConta;
        }

        public void SetApelido(string apelido)
        {
            Apelido = apelido;
        }

        public void SetConta(Conta conta)
        {
            Conta = conta;
            ContaId = conta.Id;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}