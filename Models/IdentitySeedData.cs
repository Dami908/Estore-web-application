using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "John";
        private const string adminPassword = "Secret123$";

        private const string User = "Dami";
        private const string UserPassword = "User123#";

        private const string adminRoleName = "Admin";
        private const string UserRoleName = "User";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            //    UserManager<IdentityUser> userManager = app.ApplicationServices
            //    .GetRequiredService<UserManager<IdentityUser>>();
            //    IdentityUser user = await userManager.FindByIdAsync(adminUser);
            //    if (user == null)
            //    {
            //        user = new IdentityUser("Admin");
            //        await userManager.CreateAsync(user, adminPassword);
            //    }
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .GetRequiredService<RoleManager<IdentityRole>>();

            //admin role
            IdentityRole adminRole = await roleManager.FindByNameAsync(adminRoleName);

            if (adminRole == null)
            {
                adminRole = new IdentityRole(adminRoleName);
                await roleManager.CreateAsync(adminRole);
            }

            //User role
            IdentityRole userRole = await roleManager.FindByNameAsync(UserRoleName);
            if (userRole == null)
            {
                userRole = new IdentityRole(UserRoleName);
                await roleManager.CreateAsync(userRole);
            }

            
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();

            //admin user
            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser(adminUser);
                await userManager.CreateAsync(user, adminPassword);
                await userManager.AddToRoleAsync(user, adminRoleName);
            }
            else
            {
                if (!(await userManager.IsInRoleAsync(user, adminRoleName)))
                {
                    await userManager.AddToRoleAsync(user, adminRoleName);
                }
            }

            //manager user
            IdentityUser UserIdentity = await userManager.FindByNameAsync(User);

            if (UserIdentity == null)
            {
                UserIdentity = new IdentityUser(User);
                await userManager.CreateAsync(UserIdentity, UserPassword);
                await userManager.AddToRoleAsync(UserIdentity, UserRoleName);
            }
            else
            {
                if(!(await userManager.IsInRoleAsync(UserIdentity, UserRoleName)))
                {
                    await userManager.AddToRoleAsync(UserIdentity, UserRoleName);
                }
            }

        }

    }
}
