using System;
using System.Collections.Generic;

namespace src.Entities
{
    public class TourCategory : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}