using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class Group : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid TourId { get; set; }

        public Tour Tour { get; set; }
        public ICollection<GroupDetail> GroupDetails { get; set; }
        public ICollection<GroupCost> GroupCosts { get; set; }
        public ICollection<StaffGroupRole> StaffGroupRoles { get; set; }
    }
}