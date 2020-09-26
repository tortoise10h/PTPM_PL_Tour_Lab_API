using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class CostType : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<GroupCost> GroupCosts { get; set; }
    }
}