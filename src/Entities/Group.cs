using System;
using System.Collections.Generic;
using src.Common.Enums;

namespace src.Entities
{
    public class Group : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TourId { get; set; }
        public GroupStatusEnum Status { get; set; }

        public Tour Tour { get; set; }
        public ICollection<GroupDetail> GroupDetails { get; set; }
        public ICollection<GroupCost> GroupCosts { get; set; }
        public ICollection<StaffGroupRole> StaffGroupRoles { get; set; }
    }
}