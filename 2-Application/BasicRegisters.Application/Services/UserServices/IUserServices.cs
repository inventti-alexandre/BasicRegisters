using BasicRegisters.Application.Services.UserServices.Dtos;
using System;

namespace BasicRegisters.Application.Services.UserServices
{
    public interface IUserServices : IDisposable
    {
        UserDto Find(string userID);
    }
}