using BasicRegisters.Application.Dtos_Genericos;
using FluentValidation.Results;
using System.Collections.Generic;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Dtos
{
    public class DadosIniciaisDto
    {
        public string ApelidoDaConta { get; set; }
        public string ApelidoParaUsuarioAdministrador { get; set; }
        public string EmailParaUsuarioAdministrador { get; set; }
        public string NomeDaConta { get; set; }
        public string SenhaParaUsuarioAdministrador { get; set; }
    }
}