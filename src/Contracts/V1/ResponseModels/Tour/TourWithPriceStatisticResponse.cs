namespace src.Contracts.V1.ResponseModels.Tour
{
    public class TourWithPriceStatisticResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TourCategory { get; set; }
        public long TotalPrice { get; set; }
    }
}