using FluentValidation;

namespace src.CQRS.GroupRole.Commands.UpdateGroupRole
{
    public class UpdateGroupRoleCommandValidator : AbstractValidator<UpdateGroupRoleCommand>
    {
        public UpdateGroupRoleCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}