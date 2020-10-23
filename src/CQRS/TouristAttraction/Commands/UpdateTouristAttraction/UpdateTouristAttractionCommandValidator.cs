using FluentValidation;

namespace src.CQRS.TouristAttraction.Commands.UpdateTouristAttraction
{
    public class UpdateTouristAttractionCommandValidator : AbstractValidator<UpdateTouristAttractionCommand>
    {
        public UpdateTouristAttractionCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Description)
                .NotEmpty();
        }
    }
}