using CoreBoilerplate.Application.Enums;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CoreBoilerplate.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<ExtendedIdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new ExtendedIdentityRole(Roles.Admininstrator.ToString()));
            await roleManager.CreateAsync(new ExtendedIdentityRole(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new ExtendedIdentityRole(Roles.Basic.ToString()));
        }
    }
}