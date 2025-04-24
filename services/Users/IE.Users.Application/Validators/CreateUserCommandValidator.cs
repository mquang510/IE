using FluentValidation;
using IE.Users.Application.Commands;

namespace IE.Users.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.User.Name)
                .NotEmpty().WithMessage("Tên không được để trống")
                .MaximumLength(50).WithMessage("Tên tối đa 50 ký tự");

            RuleFor(x => x.User.Email)
                .NotEmpty().WithMessage("Email không được để trống")
                .EmailAddress().WithMessage("Email không hợp lệ");
        }
    }
}
