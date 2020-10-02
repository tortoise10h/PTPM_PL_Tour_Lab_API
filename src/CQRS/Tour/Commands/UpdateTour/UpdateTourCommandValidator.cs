using FluentValidation;
using src.Common.CustomValidators;

namespace src.CQRS.Tour.Commands.UpdateTour
{
    public class UpdateTourCommandValidator : AbstractValidator<UpdateTourCommand>
    {
        public UpdateTourCommandValidator()
        {
            RuleFor(x => x.TourCategoryId)
                .SetValidator(new GuidValidator());

            RuleFor(x => x.Price)
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Specification)
                .NotEmpty();

            RuleFor(x => x.Status)
                .NotNull()
                .IsInEnum();
        }
    }
}