using System;
using FluentValidation;
using src.Common.CustomValidators;

namespace src.CQRS.Group.Commands.CreateGroup
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.TourId)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.StartDate)
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage($"Ngày bắt đầu phải lớn hơn hoặc bằng {DateTime.Now}");

            RuleFor(x => x.EndDate)
                .NotNull()
                .GreaterThan(x => x.StartDate)
                .WithMessage($"Ngày kết thúc phải lớn hơn {DateTime.Now}");
        }
    }
}