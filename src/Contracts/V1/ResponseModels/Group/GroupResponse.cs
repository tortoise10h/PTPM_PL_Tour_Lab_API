using System;
using System.Collections.Generic;
using src.Contracts.V1.ResponseModels.Tour;

namespace src.Contracts.V1.ResponseModels.Group
{
    public class GroupResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TourId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}