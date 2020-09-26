using System;

namespace src.Entities
{
    public class TourDetail : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid TourId { get; set; }
        public Guid TouristAttractionId { get; set; }

        public Tour Tour { get; set; }
        public TouristAttraction TouristAttraction { get; set; }
    }
}