using System;

namespace src.Entities
{
    public class TourDetail : BaseEntity
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int TouristAttractionId { get; set; }

        public Tour Tour { get; set; }
        public TouristAttraction TouristAttraction { get; set; }
    }
}