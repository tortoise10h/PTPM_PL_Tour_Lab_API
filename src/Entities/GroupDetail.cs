using System;

namespace src.Entities
{
    public class GroupDetail : BaseEntity
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid GroupId { get; set; }
        public string Description { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Group Group { get; set; }
    }
}