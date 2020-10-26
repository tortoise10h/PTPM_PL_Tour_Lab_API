using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace src.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<GroupDetail> GroupDetails { get; set; }
        public ICollection<StaffGroupRole> StaffGroupRoles { get; set; }
        public ICollection<IdentityUserRole<string>> IdentityUserRoles { get; set; }
    }
}