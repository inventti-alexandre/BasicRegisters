using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;

namespace BasicRegisters.Application.Services.GerarDadosIniciais
{
    public interface IDadosIniciaisServices
    {
        DadosIniciaisDto GerarDadosIniciais(DadosIniciaisDto dadosIniciaisDto);
    }
}