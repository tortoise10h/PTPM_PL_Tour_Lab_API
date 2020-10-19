namespace src.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Auth
        {
            public const string Login = Base + "/auth/login";
            public const string Register = Base + "/auth/register";
            public const string Refresh = Base + "/auth/refresh";
            public const string Profile = Base + "/auth/profiles";
        }

        public static class TourCategory
        {
            public const string Create = Base + "/tourCategories";
            public const string GetAll = Base + "/tourCategories";
            public const string Update = Base + "/tourCategories/{tourCategoryId}";
            public const string GetById = Base + "/tourCategories/{tourCategoryId}";
            public const string Delete = Base + "/tourCategories/{tourCategoryId}";
        }

        public static class Tour
        {
            public const string Create = Base + "/tours";
            public const string GetAll = Base + "/tours";
            public const string Update = Base + "/tours/{tourId}";
            public const string GetById = Base + "/tours/{tourId}";
            public const string Delete = Base + "/tours/{tourId}";
            public const string GetTourPricesOfTour = Base + "/tours/{tourId}/tourPrices";
            public const string GetGroupsOfTour = Base + "/tours/{tourId}/groups";
        }

        public static class TourDetail
        {
            public const string Create = Base + "/tourDetail";
            public const string GetAll = Base + "/tourDetail";
            public const string Update = Base + "/tourDetail/{tourDetailId}";
            public const string GetById = Base + "/tourDetail/{tourDetailId}";
            public const string Delete = Base + "/tourDetail";
        }

        public static class TouristAttraction
        {
            public const string Create = Base + "/touristAttractions";
            public const string GetAll = Base + "/touristAttractions";
            public const string Update = Base + "/touristAttractions/{touristAttractionId}";
            public const string GetById = Base + "/touristAttractions/{touristAttractionId}";
            public const string Delete = Base + "/touristAttractions/{touristAttractionId}";
        }

        public static class CostType
        {
            public const string Create = Base + "/costTypes";
            public const string GetAll = Base + "/costTypes";
            public const string Update = Base + "/costTypes/{costTypeId}";
            public const string GetById = Base + "/costTypes/{costTypeId}";
            public const string Delete = Base + "/costTypes/{costTypeId}";
        }

        public static class TourPrice
        {
            public const string Create = Base + "/tourPrices";
            public const string GetAll = Base + "/tourPrices";
            public const string Update = Base + "/tourPrices/{tourPriceId}";
            public const string GetById = Base + "/tourPrices/{tourPriceId}";
            public const string Delete = Base + "/tourPrices/{tourPriceId}";
        }

        public static class Group
        {
            public const string Create = Base + "/groups";
            public const string GetAll = Base + "/groups";
            public const string Update = Base + "/groups/{groupId}";
            public const string GetById = Base + "/groups/{groupId}";
            public const string Delete = Base + "/groups/{groupId}";
        }
    }
}