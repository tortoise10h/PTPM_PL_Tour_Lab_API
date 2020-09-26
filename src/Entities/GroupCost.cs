using System;

namespace src.Entities
{
    public class GroupCost : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid CostTypeId { get; set; }
        public long Price { get; set; }
        public string Note { get; set; }

        public Group Group { get; set; }
        public CostType CostType { get; set; }
    }
}