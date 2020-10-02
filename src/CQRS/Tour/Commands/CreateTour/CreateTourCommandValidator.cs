using FluentValidation;
using src.Common.CustomValidators;

namespace src.CQRS.Tour.Commands.CreateTour
{
    public class CreateTourCommandValidator : AbstractValidator<CreateTourCommand>
    {
        public CreateTourCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.TourCategoryId)
                .NotEmpty()
                .NotNull()
                .SetValidator(new GuidValidator());

            RuleFor(x => x.Price)
                .NotNull()
                .GreaterThan(0);
        }
    }
}