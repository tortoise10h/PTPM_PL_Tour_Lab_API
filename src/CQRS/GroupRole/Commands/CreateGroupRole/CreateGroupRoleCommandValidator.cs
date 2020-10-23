using FluentValidation;

namespace src.CQRS.GroupRole.Commands.CreateGroupRole
{
    public class CreateGroupRoleCommandValidator : AbstractValidator<CreateGroupRoleCommand>
    {
        public CreateGroupRoleCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}