using System;
using src.Contracts.V1.ResponseModels.TouristAttraction;

namespace src.Contracts.V1.ResponseModels.TourDetail
{
    public class TourDetailResponse
    {
        public Guid TourId { get; set; }
        public TouristAttractionResponse TouristAttraction { get; set; }
    }
}