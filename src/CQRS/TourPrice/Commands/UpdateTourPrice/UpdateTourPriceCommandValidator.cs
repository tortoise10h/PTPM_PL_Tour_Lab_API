using System;
using FluentValidation;
using src.Common.CustomValidators;
using src.CQRS.TourPrice.Commands.CreateTourPrice;

namespace src.CQRS.TourPrice.Commands.UpdateTourPrice
{
    public class UpdateTourPriceCommandValidator : AbstractValidator<UpdateTourPriceCommand>
    {
        public UpdateTourPriceCommandValidator()
        {
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
