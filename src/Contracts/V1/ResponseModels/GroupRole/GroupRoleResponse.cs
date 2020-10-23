using System;

namespace src.Contracts.V1.ResponseModels.GroupRole
{
    public class GroupRoleResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}