using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Dtos
{
    public class GerarDadosIniciaisDto
    {
        public ContaDto ContaDto { get; set; }

        public UsuarioDto UsuarioDto { get; set; }
    }
}