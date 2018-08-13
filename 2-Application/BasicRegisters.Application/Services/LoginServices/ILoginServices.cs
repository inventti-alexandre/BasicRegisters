using BasicRegisters.Application.Services.LoginServices.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;

namespace BasicRegisters.Application.Services.LoginServices
{
    public interface ILoginServices
    {
        AutenticacaoDoLogin FazerLogin(LoginDto usuario);
    }
}