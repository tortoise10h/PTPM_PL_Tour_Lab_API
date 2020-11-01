using FluentValidation;

namespace src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole
{
    public class CreateStaffGroupRoleCommandValidator : AbstractValidator<CreateStaffGroupRoleCommand>
    {
        public CreateStaffGroupRoleCommandValidator()
        {
            RuleFor(x => x.GroupId)
                .NotEmpty();

            RuleForEach(x => x.GroupRoles)
                .NotEmpty();

            RuleFor(x => x.StaffId)
                .NotEmpty();
        }
    }
}