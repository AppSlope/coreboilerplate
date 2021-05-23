namespace CoreBoilerplate.Infrastructure.Constants
{
    public static class DefaultIdentityConstants
    {
        public static class RoleConstant
        {
            public const string AdministratorRole = "Administrator";
            public const string BasicRole = "Basic";
        }

        public static class DefaultAdministrator
        {
            public const string UserName = "administrator";
            public const string Email = "admin@fullstackhero.com";
            public const string FirstName = "Mukesh";
            public const string LastName = "Murugan";
            public const string Password = "123Pa$$word!";
        }

        public static class DefaultBasicUser
        {
            public const string UserName = "basicuser";
            public const string Email = "basicuser@fullstackhero.com";
            public const string FirstName = "John";
            public const string LastName = "Doe";
            public const string Password = "123Pa$$word!";
        }
    }
}