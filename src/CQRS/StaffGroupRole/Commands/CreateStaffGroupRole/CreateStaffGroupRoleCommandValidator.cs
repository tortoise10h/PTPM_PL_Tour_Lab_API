using FluentValidation;

namespace src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole
{
    public class CreateStaffGroupRoleCommandValidator : AbstractValidator<CreateStaffGroupRoleCommand>
    {
        public CreateStaffGroupRoleCommandValidator()
        {
            RuleFor(x => x.GroupId)
                .NotEmpty();

            RuleFor(x => x.GroupRoleId)
                .NotEmpty();

            RuleFor(x => x.StaffId)
                .NotEmpty();
        }
    }
}