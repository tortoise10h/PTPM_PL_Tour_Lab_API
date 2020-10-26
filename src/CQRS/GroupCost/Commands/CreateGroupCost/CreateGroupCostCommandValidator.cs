using FluentValidation;

namespace src.CQRS.GroupCost.Commands.CreateGroupCost
{
    public class CreateGroupCostCommandValidator : AbstractValidator<CreateGroupCostCommand>
    {
        public CreateGroupCostCommandValidator()
        {
            RuleFor(x => x.GroupId)
                .NotEmpty();

            RuleFor(x => x.CostTypeId)
                .NotEmpty();

            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}