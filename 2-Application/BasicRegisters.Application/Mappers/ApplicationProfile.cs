using AutoMapper;
using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;

namespace BasicRegisters.Application.Mappers
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Conta, ContaDto>();
            CreateMap<Usuario, UsuarioDto>();
        }
    }
}