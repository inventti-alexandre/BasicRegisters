using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using System;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public interface IDadosIniciaisServices
    {
        GerarDadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto);
    }
}