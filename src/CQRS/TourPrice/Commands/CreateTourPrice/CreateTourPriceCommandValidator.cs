using System;
using FluentValidation;
using src.Common.CustomValidators;

namespace src.CQRS.TourPrice.Commands.CreateTourPrice
{
    public class CreateTourPriceCommandValidator : AbstractValidator<CreateTourPriceCommand>
    {
        public CreateTourPriceCommandValidator()
        {
            RuleFor(x => x.TourId)
                .NotEmpty()
                .SetValidator(new GuidValidator());

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