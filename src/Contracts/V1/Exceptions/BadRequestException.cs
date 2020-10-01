using System;
using System.Collections.Generic;

namespace src.Contracts.V1.Exceptions
{
    public class BadRequestException : Exception
    {
        public ApiError Errors { get; set; }

        public BadRequestException(ApiError errors)
        {
            Errors = errors;
        }
    }
}