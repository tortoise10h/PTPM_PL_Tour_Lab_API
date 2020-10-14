using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class TouristAttraction : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<TourDetail> TourDetails { get; set; }

    }
}