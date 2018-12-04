using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;

namespace BasicRegisters.Application.Dtos_Genericos
{
    public abstract class BaseDto
    {
        public IList<ValidationFailure> Errors { get; set; }
        public bool IsValid { get; set; }

        public BaseDto Validar(IValidator validator)
        {
            var validacao = validator.Validate(this);

            Errors = validacao.Errors;
            IsValid = validacao.IsValid;

            return this;
        }
    }
}