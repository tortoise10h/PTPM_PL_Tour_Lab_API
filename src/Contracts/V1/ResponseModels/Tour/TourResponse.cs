using System;
using src.Enums;

namespace src.Contracts.V1.ResponseModels.Tour
{
    public class TourResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public Guid TourCategoryId { get; set; }
        public double Price { get; set; }
        public TourStatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}