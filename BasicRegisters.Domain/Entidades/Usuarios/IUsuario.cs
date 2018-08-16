using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades.Usuarios
{
    internal interface IUsuario : IBaseEntidade<Usuario>
    {
        string Apelido { get; set; }
        Guid ContaId { get; set; }
        string Email { get; set; }
        string Senha { get; set; }

        Usuario SetApelido(string apelido);

        Usuario SetConta(Conta senha);

        Usuario SetEmail(string email);

        Usuario SetSenha(string senha);
    }
}