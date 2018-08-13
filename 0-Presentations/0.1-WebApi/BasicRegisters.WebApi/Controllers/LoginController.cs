using AutoMapper;
using BasicRegisters.Application.Services.LoginServices;
using BasicRegisters.Application.Services.LoginServices.Dtos;
using BasicRegisters.WebApi.ViewModels.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicRegisters.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public object Post(
            [FromBody]LoginViewModel usuario,
            [FromServices]LoginServices _loginServices,
            [FromServices]IMapper _mapper)
        {
            return _loginServices.FazerLogin(_mapper.Map<LoginViewModel, LoginDto>(usuario));
        }
    }
}