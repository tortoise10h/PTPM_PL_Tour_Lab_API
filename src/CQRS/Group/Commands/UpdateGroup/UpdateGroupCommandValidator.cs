using System;
using FluentValidation;
using src.Common.CustomValidators;

namespace src.CQRS.Group.Commands.UpdateGroup
{
    public class UpdateGroupCommandValidator : AbstractValidator<UpdateGroupCommand>
    {
        public UpdateGroupCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.StartDate)
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage($"Ngày bắt đầu phải lớn hơn hoặc bằng {DateTime.Now}");

            RuleFor(x => x.EndDate)
                .NotNull()
                .GreaterThan(x => x.StartDate)
                .WithMessage($"Ngày kết thúc phải lớn hơn {DateTime.Now}");

            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Status)
                .IsInEnum();
        }
    }
}