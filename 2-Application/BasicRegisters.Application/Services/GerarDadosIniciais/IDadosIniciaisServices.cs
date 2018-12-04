using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using FluentValidation.Results;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public interface IDadosIniciaisServices
    {
        DadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto);

    }
}