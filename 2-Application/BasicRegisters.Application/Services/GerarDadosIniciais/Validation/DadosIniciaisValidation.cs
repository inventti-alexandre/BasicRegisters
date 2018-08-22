using BasicRegisters.Application.Services.GerarDadosIniciais.Dtos;
using EFGetStarted.AspNetCore.NewDb.Models;
using FluentValidation;
using System.Linq;

namespace BasicRegisters.Application.Services.GerarDadosIniciais.Validation
{
    public class DadosIniciaisValidation : AbstractValidator<DadosIniciaisDto>
    {
        private readonly BasicRegistersContext _context;

        public DadosIniciaisValidation(BasicRegistersContext context)
        {
            _context = context;

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
                .WithMessage("O e-mail do usuário não pode ter mais que 120 caracteres.")
                .Must(ValidarEmailExistente).WithMessage("O email do usuário já esta cadastrado.");

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

        public bool ValidarEmailExistente(string email)
        {
            return !_context
                    .Usuarios
                    .Any(c => c.Email == email);
        }
    }
}