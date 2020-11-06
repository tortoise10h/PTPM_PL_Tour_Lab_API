namespace src.Contracts.V1.ResponseModels.Tour
{
    public class TourWithGroupStatisticResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TourCategory { get; set; }
        public int TourArrival { get; set; }
        public int TourCancel { get; set; }

    }
}