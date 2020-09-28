
using System.Collections.Generic;

namespace src.Contracts.V1.ResponseModels
{
    public class PagedResponse<T>
    {
        public PagedResponse()
        {

        }

        public PagedResponse(IEnumerable<T> data)
        {
            Data = data;
        }

        public IEnumerable<T> Data { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public string NextPage { get; set; }
        public string PreviousPage { get; set; }
        public int TotalPage { get; set; }

    }
}