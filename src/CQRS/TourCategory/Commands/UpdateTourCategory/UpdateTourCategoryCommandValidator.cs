using FluentValidation;

namespace src.CQRS.TourCategory.Commands.UpdateTourCategory
{
    public class UpdateTourCategoryCommandValidator : AbstractValidator<UpdateTourCategoryCommand>
    {
        public UpdateTourCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}