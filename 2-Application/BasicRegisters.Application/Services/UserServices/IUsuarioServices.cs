using BasicRegisters.Application.Services.UserServices.Dtos;
using System;

namespace BasicRegisters.Application.Services.UserServices
{
    public interface IUsuarioServices : IDisposable
    {
        UsuarioDto Find(string userID);
    }
}