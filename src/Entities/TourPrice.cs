using System;

namespace src.Entities
{
    public class TourPrice : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid TourId { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Tour Tour { get; set; }
    }
}