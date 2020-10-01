using System.Dynamic;

namespace src.Contracts.V1.Exceptions
{
    public class ApiError
    {
        public dynamic ApiErr { get; set; }

        public ApiError(string error)
        {
            ApiErr = new ExpandoObject();
            ApiErr = error;
        }
    }
}