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
    }
}