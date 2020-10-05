using src.Common.Enums;

namespace src.Contracts.V1.RequestModels
{
    public class PaginationQuery
    {
        public int Page { get; set; } = PaginationDefault.Page;
        public int Limit { get; set; } = PaginationDefault.Limit;
        public string SortName { get; set; } = PaginationDefault.SortName;
        public bool IsAscending { get; set; } = PaginationDefault.IsAscending;
    }
}