using System;

namespace src.Entities
{
    public class StaffGroupRole : BaseEntity
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public int GroupId { get; set; }
        public int GroupRoleId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Group Group { get; set; }
        public GroupRole GroupRole { get; set; }
    }
}