using FluentValidation;

namespace src.CQRS.CostType.Commands.UpdateCostType
{
    public class UpdateCostTypeCommandValidator : AbstractValidator<UpdateCostTypeCommand>
    {
        public UpdateCostTypeCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}