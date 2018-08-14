using BasicRegisters.Domain.Entidades.Interfaces;
using System;

namespace BasicRegisters.Domain.Entidades.Usuarios
{
    internal interface IUsuario : IBaseEntidade
    {
        string Apelido { get; set; }
        Guid ContaId { get; set; }
        string Email { get; set; }
        string Senha { get; set; }
    }
}