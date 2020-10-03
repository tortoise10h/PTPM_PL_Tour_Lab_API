using FluentValidation;

namespace src.CQRS.CostType.Commands.CreateCostType
{
    public class CreateCostTypeCommandValidator : AbstractValidator<CreateCostTypeCommand>
    {
        public CreateCostTypeCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}