using src.Contracts.V1.ResponseModels.GroupRole;
using src.Contracts.V1.ResponseModels.User;

namespace src.Contracts.V1.ResponseModels.StaffGroupRole
{
    public class StaffGroupRoleResponse
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string StaffId { get; set; }
        public UserResponse ApplicationUser { get; set; }
        public int GroupRoleId { get; set; }
        public GroupRoleResponse GroupRole { get; set; }
    }
}