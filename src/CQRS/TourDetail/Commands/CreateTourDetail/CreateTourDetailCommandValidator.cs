using FluentValidation;

namespace src.CQRS.TourDetail.Commands.CreateTourDetail
{
    public class CreateTourDetailCommandValidator : AbstractValidator<CreateTourDetailCommand>
    {
        public CreateTourDetailCommandValidator()
        {
            RuleForEach(x => x.TouristAttractionIds)
                .NotEmpty();

            RuleFor(x => x.TourId)
                .NotEmpty();
        }
    }
}