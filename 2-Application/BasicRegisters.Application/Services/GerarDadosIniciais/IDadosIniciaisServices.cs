using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using FluentValidation.Results;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public interface IDadosIniciaisServices
    {
        GerarDadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto);

        GerarDadosIniciaisDto RegistrarErros(GerarDadosIniciaisDto gerarDadosIniciaisDto, ValidationResult validationResult);
    }
}