using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using FluentValidation;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Validation
{
    public class DadosIniciaisValidation : AbstractValidator<DadosIniciaisDto>
    {
        public DadosIniciaisValidation()
        {
            RuleFor(c => c.ApelidoDaConta)
                .NotNull()
                .WithMessage("Não pode ser nullo");
        }
    }
}