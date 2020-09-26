using System;
using System.Collections.Generic;
using src.Contracts.V1.ResponseModels.User;

namespace src.Contracts.V1.ResponseModels.Auth
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public string Token { get; set; }
        public UserResponse UserResponse { get; set; }
        public string RefreshToken { get; set; }
        public DateTime TokenExpireTime { get; set; }
    }
}