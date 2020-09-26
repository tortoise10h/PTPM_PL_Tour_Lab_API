using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class Tour : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public Guid TourCategoryId { get; set; }
        public long Price { get; set; }

        public TourCategory TourCategory { get; set; }
        public ICollection<TourPrice> TourPrices { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<TourDetail> TourDetails { get; set; }
    }
}