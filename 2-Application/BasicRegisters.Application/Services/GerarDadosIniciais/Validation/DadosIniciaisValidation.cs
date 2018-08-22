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
                .WithMessage("O apelido da conta não pode ser nulo.")
                .MinimumLength(3)
                .WithMessage("O apelido da conta deve ter no minimo 3 caracteres.")
                .MaximumLength(20)
                .WithMessage("O apelido da conta não pode ter mais que 20 caracteres.");

            RuleFor(c => c.ApelidoParaUsuarioAdministrador)
                .NotNull()
                .WithMessage("O apelido do usuário não pode ser nulo.")
                .MinimumLength(3)
                .WithMessage("O apelido do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(32)
                .WithMessage("O apelido do usuário não pode ter mais que 20 caracteres.");

            RuleFor(c => c.EmailParaUsuarioAdministrador)
                .NotNull()
                .WithMessage("O e-mail do usuário não pode ser nulo.")
                .MinimumLength(3)
                .WithMessage("O e-mail do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(120)
                .WithMessage("O e-mail do usuário não pode ter mais que 120 caracteres.");

            RuleFor(c => c.NomeDaConta)
                .NotNull()
                .WithMessage("O nome da conta não pode ser nulo.")
                .MinimumLength(3)
                .WithMessage("O e-mail do usuário deve ter no minimo 3 caracteres.")
                .MaximumLength(120)
                .WithMessage("O e-mail do usuário não pode ter mais que 120 caracteres.");

            RuleFor(c => c.SenhaParaUsuarioAdministrador)
                .NotNull()
                .WithMessage("A senha do usuário não pode ser nula.")
                .NotEmpty()
                .WithMessage("A senha do usuário administrador deve ser preenchida.");
        }
    }
}