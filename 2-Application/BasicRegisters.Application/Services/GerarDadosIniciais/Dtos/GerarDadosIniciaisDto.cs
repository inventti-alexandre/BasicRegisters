using BasicRegisters.Application.Dtos_Genericos;
using BasicRegisters.Application.Services.ContaServices.Dtos;
using BasicRegisters.Application.Services.UserServices.Dtos;
using FluentValidation.Results;
using System.Collections.Generic;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Dtos
{
    public class GerarDadosIniciaisDto : IBaseDto
    {
        public ContaDto ContaDto { get; set; }

        public IList<ValidationFailure> Errors { get; set; }
        public bool IsValid { get; set; }
        public UsuarioDto UsuarioDto { get; set; }
    }
}