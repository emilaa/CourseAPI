using FluentValidation;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Helpers;

namespace ServiceLayer.Validations.Account
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(u => u.Email).NotNull().NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(6, 12).Must(u => PasswordExtentions.HasValidPassword(u));
        }
    }
}
