using System;
using src.Contracts.V1.ResponseModels.User;
using src.Entities;

namespace src.Contracts.V1.ResponseModels.GroupDetail
{
    public class GroupDetailResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public UserResponse ApplicationUser { get; set; }
    }
}