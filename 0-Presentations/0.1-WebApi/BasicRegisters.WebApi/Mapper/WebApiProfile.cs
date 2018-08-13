using AutoMapper;
using BasicRegisters.Application.Services.UserServices.Dtos;
using BasicRegisters.WebApi.ViewModels.Login;

namespace BasicRegisters.WebApi.Mapper
{
    public class WebApiProfile : Profile
    {
        public WebApiProfile()
        {
            CreateMap<UsuarioDto, LoginViewModel>();
            CreateMap<LoginViewModel, UsuarioDto>()
                .ForMember(x => x.Id, opts => opts.Ignore());
        }
    }
}