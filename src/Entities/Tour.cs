using System;
using System.Collections.Generic;
using src.Common.Enums;

namespace src.Entities
{
    public class Tour : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public int TourCategoryId { get; set; }
        public long Price { get; set; }
        public TourStatusEnum Status { get; set; }

        public TourCategory TourCategory { get; set; }
        public ICollection<TourPrice> TourPrices { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<TourDetail> TourDetails { get; set; }
    }
}