using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using FluentValidation;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Validation
{
    public class DadosIniciaisValidation : AbstractValidator<DadosIniciaisDto>
    {
        public DadosIniciaisValidation()
        {
            RuleFor(c => c.ApelidoDaConta)
                .MinimumLength(3)
                .WithMessage("O apelido da conta deve ter no minimo 3 caracteres.")
                .MaximumLength(20)
                .WithMessage("O apelido da conta não pode ter mais que 20 caracteres.");

            RuleFor(c => c.ApelidoParaUsuarioAdministrador)
                .MinimumLength(3)
                .WithMessage("O apelido do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(32)
                .WithMessage("O apelido do usuário não pode ter mais que 20 caracteres.");

            RuleFor(c => c.EmailParaUsuarioAdministrador)
                .MinimumLength(3)
                .WithMessage("O e-mail do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(120)
                .WithMessage("O e-mail do usuário não pode ter mais que 120 caracteres.");

            RuleFor(c => c.NomeDaConta)
                .MinimumLength(3)
                .WithMessage("O e-mail do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(120)
                .WithMessage("O e-mail do usuário não pode ter mais que 120 caracteres.");

            RuleFor(c => c.SenhaParaUsuarioAdministrador)
                .NotEmpty()
                .WithMessage("A senha do usuário administrador deve ser preenchida.");
        }
    }
}