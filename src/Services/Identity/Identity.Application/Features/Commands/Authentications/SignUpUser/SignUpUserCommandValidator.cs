using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Features.Commands.Authentications.SignUpUser
{
    public class SignUpUserCommandValidator:AbstractValidator<SignUpUserCommand>
    {
        public SignUpUserCommandValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("{Email Address} is required.");

            RuleFor(p => p.Password).NotEmpty().WithMessage("{Password} is required.");
        }
    }
}
