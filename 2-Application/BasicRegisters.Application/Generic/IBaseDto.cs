using FluentValidation.Results;
using System.Collections.Generic;

namespace BasicRegisters.Application.Dtos_Genericos
{
    public interface IBaseDto
    {
        IList<ValidationFailure> Errors { get; }
        bool IsValid { get; }
    }
}