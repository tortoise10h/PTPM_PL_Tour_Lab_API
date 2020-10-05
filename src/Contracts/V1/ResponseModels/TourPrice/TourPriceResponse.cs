using System;

namespace src.Contracts.V1.ResponseModels.TourPrice
{
    public class TourPriceResponse
    {
        public Guid Id { get; set; }
        public Guid TourId { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}