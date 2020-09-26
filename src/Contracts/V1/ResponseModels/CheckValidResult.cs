using System.Collections.Generic;

namespace src.Contracts.V1.ResponseModels
{
    public class CheckValidResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
    }
}