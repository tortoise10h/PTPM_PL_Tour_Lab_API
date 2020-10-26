using FluentValidation;

namespace src.CQRS.GroupCost.Commands.UpdateGroupCost
{
    public class UpdateGroupCostCommandValidator : AbstractValidator<UpdateGroupCostCommand>
    {
        public UpdateGroupCostCommandValidator()
        {
            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}