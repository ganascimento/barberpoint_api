using FluentValidation;
using GADev.BarberPoint.Application.Commands.Authentication;

namespace GADev.BarberPoint.Application.Validators.Authentication
{
    public class LoginUserValidator : AbstractValidator<LoginUserCommand>
    {
        public LoginUserValidator()
        {
            RuleFor(a => a.Email)
                .NotNull().WithMessage("O campo 'Email' é obrigatório")
                .NotEmpty().WithMessage("O campo 'Email' deve ser preenchido")
                .EmailAddress(mode: FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("O campo 'Email' está em um formato incorreto")
                .MinimumLength(6).WithMessage("O campo 'Email' deve conter pelo menos 6 caracteres")
                .MaximumLength(80).WithMessage("O campo 'Email' deve conter no máximo 80 caracteres");

            RuleFor(a => a.Password)
                .NotNull().WithMessage("O campo 'Password' é obrigatório")
                .NotEmpty().WithMessage("O campo 'Password' deve ser preenchido")
                .MinimumLength(6).WithMessage("O campo 'Password' deve conter pelo menos 6 caracteres")
                .MaximumLength(30).WithMessage("O campo 'Password' deve conter no máximo 30 caracteres");
        }
    }
}