using System;

namespace src.Entities
{
    public class GroupCost : BaseEntity
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CostTypeId { get; set; }
        public long Price { get; set; }
        public string Note { get; set; }

        public Group Group { get; set; }
        public CostType CostType { get; set; }
    }
}