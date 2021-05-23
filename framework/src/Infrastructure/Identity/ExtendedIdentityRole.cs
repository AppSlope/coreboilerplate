using Microsoft.AspNetCore.Identity;

namespace CoreBoilerplate.Infrastructure.Identity
{
    public class ExtendedIdentityRole : IdentityRole<int>
    {
        public ExtendedIdentityRole()
        {

        }
        public ExtendedIdentityRole(string roleName)
        {
            Name = roleName;
            NormalizedName = roleName.ToUpper();
        }
    }
}
