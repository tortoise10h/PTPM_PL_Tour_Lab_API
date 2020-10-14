using System;
using src.Contracts.V1.ResponseModels.TouristAttraction;

namespace src.Contracts.V1.ResponseModels.TourDetail
{
    public class TourDetailResponse
    {
        public int TourId { get; set; }
        public TouristAttractionResponse TouristAttraction { get; set; }
        public int Index { get; set; }
    }
}