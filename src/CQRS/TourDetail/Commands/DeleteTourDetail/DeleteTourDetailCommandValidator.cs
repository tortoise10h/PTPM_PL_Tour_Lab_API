using FluentValidation;

namespace src.CQRS.TourDetail.Commands.DeleteTourDetail
{
    public class DeleteTourDetailCommandValidator : AbstractValidator<DeleteTourDetailCommand>
    {
        public DeleteTourDetailCommandValidator()
        {
            RuleForEach(x => x.TouristAttractionIds)
               .NotEmpty();

            RuleFor(x => x.TourId)
                .NotEmpty();
        }
    }
}