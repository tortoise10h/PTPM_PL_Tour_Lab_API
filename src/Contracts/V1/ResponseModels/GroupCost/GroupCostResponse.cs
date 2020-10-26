using System;
using src.Contracts.V1.ResponseModels.CostType;

namespace src.Contracts.V1.ResponseModels.GroupCost
{
    public class GroupCostResponse
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CostTypeId { get; set; }
        public CostTypeResponse CostType { get; set; }
        public long Price { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}