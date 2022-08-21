using FluentValidation;
using Validating.Models;

namespace Validating.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("{PropertyName} must not be Empty!").NotNull().Length(3, 25).Must(beValidName).WithMessage("{PropertyName} must be valid!");

            RuleFor(user => user.LastName).NotEmpty().WithMessage("{PropertyName} must not be Empty!").NotNull().Length(3, 25).Must(beValidName).WithMessage("{PropertyName} must be valid!");

            RuleFor(user => user.Email).NotEmpty().NotNull().EmailAddress();

            RuleFor(user => user.PassWord).NotEmpty().NotNull().MinimumLength(5).MaximumLength(50).Must((user, PassWord) => user.ConfirmPassWord == PassWord); 
        }


        private bool beValidName(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
                return firstName.All(char.IsLetter);

            return false;
        }
    }
}
