using FluentValidation;
using src.CQRS.TourCategory.Commands.CreateTourCategory;

namespace src.CQRS.TourCategory.Commands.CreateTourCategory
{
    public class CreateTourCategoryCommandValidator : AbstractValidator<CreateTourCategoryCommand>
    {
        public CreateTourCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}