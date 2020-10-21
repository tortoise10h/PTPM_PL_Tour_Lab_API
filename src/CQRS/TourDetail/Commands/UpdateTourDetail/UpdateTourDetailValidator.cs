using FluentValidation;

namespace src.CQRS.TourDetail.Commands.UpdateTourDetail
{
    public class UpdateTourDetailValidator : AbstractValidator<UpdateTourDetailCommand>
    {
        public UpdateTourDetailValidator()
        {
            // RuleForEach(x => x.TouristAttractionIds)
            //    .NotEmpty();

            // RuleFor(x => x.TourId)
            //     .NotEmpty();

            // RuleForEach(x => x.Index)
            //     .NotNull()
            //     .GreaterThan(0);
        }
    }
}