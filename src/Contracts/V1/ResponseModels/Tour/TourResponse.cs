using System;
using System.Collections.Generic;
using src.Contracts.V1.ResponseModels.TourDetail;
using src.Common.Enums;
using src.Contracts.V1.ResponseModels.TourCategory;

namespace src.Contracts.V1.ResponseModels.Tour
{
    public class TourResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public int TourCategoryId { get; set; }
        public TourCategoryResponse TourCategory { get; set; }
        public double Price { get; set; }
        public TourStatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }

        public IEnumerable<TourDetailResponse> TourDetails { get; set; }
    }
}