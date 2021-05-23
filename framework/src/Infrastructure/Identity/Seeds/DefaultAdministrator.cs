using CoreBoilerplate.Application.Constants;
using CoreBoilerplate.Application.Enums;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBoilerplate.Infrastructure.Identity.Seeds
{
    public static class DefaultAdministrator
    {
        public static async Task SeedAsync(UserManager<ExtendedIdentityUser> userManager)
        {
            var defaultUser = new ExtendedIdentityUser
            {
                UserName = DefaultIdentityConstants.DefaultAdministrator.UserName,
                Email = DefaultIdentityConstants.DefaultAdministrator.Email,
                FirstName = DefaultIdentityConstants.DefaultAdministrator.FirstName,
                LastName = DefaultIdentityConstants.DefaultAdministrator.LastName,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                IsActive = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, DefaultIdentityConstants.DefaultAdministrator.Password);
                    await userManager.AddToRoleAsync(defaultUser, Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admininstrator.ToString());
                }
            }
        }
    }
}