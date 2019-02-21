using System;
using System.Collections.Generic;
using System.Text;

namespace CaseSolutionsTokenValidationParameters.Models
{
    public class TokenValidationConstants
    {
        public static class Roles
        {
            public const string AdminAccess = "admin_access";
            public const string CommonUserAccess = "common_user_access";
            public const string Role = "rol";
            public const string Id = "id";

        }

        public static class Policies
        {
            public const string AuthAPIAdmin = "Auth.API.Admin";
            public const string AuthAPICommonUser = "Auth.API.CommonUser";
        }
    }
}
