using System;

namespace src.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public String LastModifiedBy { get; set; }
    }
}