using FluentValidation;

namespace src.CQRS.GroupDetail.Commands.UpdateGroupDetail
{
    public class UpdateGroupDetailCommandValidator : AbstractValidator<UpdateGroupDetailCommand>
    {
        public UpdateGroupDetailCommandValidator()
        {

        }
    }
}