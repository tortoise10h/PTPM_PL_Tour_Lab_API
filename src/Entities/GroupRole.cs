using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class GroupRole : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<StaffGroupRole> StaffGroupRoles { get; set; }
    }
}