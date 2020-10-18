using FluentValidation;

namespace src.CQRS.GroupDetail.Commands.CreateGroupDetail
{
    public class CreateGroupDetailValidator : AbstractValidator<CreateGroupDetailCommand>
    {
        public CreateGroupDetailValidator()
        {
            RuleForEach(x => x.UserIds)
                .NotEmpty();

            RuleFor(x => x.GroupId)
                .NotEmpty();
        }
    }
}