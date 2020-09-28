using src.Enums;

namespace src.Contracts.V1.RequestModels
{
    public class PaginationQuery
    {
        public int Page { get; set; } = (int)PaginationEnum.Page;
        public int Limit { get; set; } = (int)PaginationEnum.Limit;
    }
}