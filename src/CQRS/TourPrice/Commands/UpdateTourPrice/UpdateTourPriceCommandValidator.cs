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
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage($"Ngày bắt đầu phải lớn hơn hoặc bằng {DateTime.Now}");

            RuleFor(x => x.EndDate)
                .NotNull()
                .GreaterThan(x => x.StartDate)
                .WithMessage($"Ngày kết thúc phải lớn hơn {DateTime.Now}");

            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
