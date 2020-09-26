using System.Collections.Generic;

namespace src.Contracts.V1.ResponseModels
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}