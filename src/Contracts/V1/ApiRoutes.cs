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
            public const string Update = Base + "/tourDetail";
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
            public const string GetGroupCostsOfGroup = Base + "/groups/{groupId}/groupCosts";
            public const string GetStaffsOfGroup = Base + "/groups/{groupId}/staffs";
            public const string GetStaffsWithoutRoleOfGroup = Base + "/groups/{groupId}/staffsWithoutRole";
            public const string DeleteStaffOfGroup = Base + "/groups/staff";
        }

        public static class GroupDetail
        {
            public const string Create = Base + "/groupDetails";
            public const string GetAll = Base + "/groupDetails";
            public const string Update = Base + "/groupDetails/{groupDetailId}";
            public const string GetById = Base + "/groupDetails/{groupDetailId}";
            public const string Delete = Base + "/groupDetails/{groupDetailId}";
        }

        public static class GroupRole
        {
            public const string Create = Base + "/groupRoles";
            public const string GetAll = Base + "/groupRoles";
            public const string Update = Base + "/groupRoles/{groupRoleId}";
            public const string GetById = Base + "/groupRoles/{groupRoleId}";
            public const string Delete = Base + "/groupRoles/{groupRoleId}";
        }

        public static class User
        {
            public const string GetAllCustomers = Base + "/users/customers";
            public const string GetAllStaffs = Base + "/users/staffs";

        }

        public static class GroupCost
        {
            public const string Create = Base + "/groupCosts";
            public const string GetAll = Base + "/groupCosts";
            public const string Update = Base + "/groupCosts/{groupCostId}";
            public const string GetById = Base + "/groupCosts/{groupCostId}";
            public const string Delete = Base + "/groupCosts/{groupCostId}";
        }

        public static class StaffGroupRole
        {
            public const string Create = Base + "/staffGroupRoles";
            public const string GetAll = Base + "/staffGroupRoles";
            public const string Update = Base + "/staffGroupRoles/{staffGroupRoleId}";
            public const string GetById = Base + "/staffGroupRoles/{staffGroupRoleId}";
            public const string Delete = Base + "/staffGroupRoles/{staffGroupRoleId}";
        }
    }
}