using System.Collections.Generic;

namespace src.Contracts.V1.ResponseModels.Tour
{
    public class TourWithPriceStatisticResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TourCategory { get; set; }
        public long TotalPrice { get; set; }
        public List<long> GroupCostList { get; set; }
        public List<long> GroupCustomerList { get; set; }
    }
}