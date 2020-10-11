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
                .GreaterThanOrEqualTo(DateTime.Now);

            RuleFor(x => x.EndDate)
                .NotNull()
                .GreaterThan(x => x.StartDate);

            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThan(0);
        }
    }
}