using FluentValidation;

namespace src.CQRS.TouristAttraction.Commands.CreateTouristAttraction
{
    public class CreateTouristAttractionCommandValidator : AbstractValidator<CreateTouristAttractionCommand>
    {
        public CreateTouristAttractionCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}