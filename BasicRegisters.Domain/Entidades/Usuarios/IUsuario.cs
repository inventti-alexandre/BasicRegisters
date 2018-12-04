using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Base.Interfaces;
using BasicRegisters.Domain.Entidades.Contas;
using System;

namespace BasicRegisters.Domain.Entidades.Usuarios
{
    internal interface IUsuario : IBaseEntidade<Usuario>
    {
        string Apelido { get; }
        Guid ContaId { get; }
        string Email { get; }
        string Senha { get; }

        void SetApelido(string apelido);

        void SetConta(Conta senha);

        void SetEmail(string email);

        void SetSenha(string senha);
    }
}