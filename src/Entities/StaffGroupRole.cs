using System;

namespace src.Entities
{
    public class StaffGroupRole : BaseEntity
    {
        public Guid Id { get; set; }
        public string StaffId { get; set; }
        public Guid GroupId { get; set; }
        public Guid GroupRoleId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Group Group { get; set; }
        public GroupRole GroupRole { get; set; }
    }
}