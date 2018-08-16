using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using System;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public interface IDadosIniciaisServices
    {
        Tuple<ContaDto, UsuarioDto> GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto);
    }
}