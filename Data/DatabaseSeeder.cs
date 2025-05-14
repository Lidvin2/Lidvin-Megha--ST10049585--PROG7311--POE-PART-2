using Microsoft.AspNetCore.Identity;

namespace PROG7311_POEPART2.Data
{
    public class DatabaseSeeder
    {
        public static async Task SeedRolesandUsers(IServiceProvider serviceProvider)
        {
            // This is two types of management role and user with both of them I can get different type of identity plus to create a username and a password to login on the page I want to do.
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roles = { "FarmerRole", "EmployeeUser" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var farmerRole = new IdentityUser
            {
                UserName = "farmerRole11@gmail.com",
                Email = "farmerRole11@gmail.com"
            };

            if (userManager.Users.All(u => u.UserName != farmerRole.UserName))
            {
                var result = await userManager.CreateAsync(farmerRole, "farmerRole11@@");
                if (result.Succeeded )
                {
                    await userManager.AddToRoleAsync(farmerRole, "FarmerRole");
                }
            }

            var employeeUser = new IdentityUser
            {
                UserName = "employeeUser11@gmail.com",
                Email = "employeeUser11@gmail.com"
            };

            if (userManager.Users.All(u => u.UserName != employeeUser.UserName))
            {
                var result = await userManager.CreateAsync(employeeUser, "employeeUser11@@");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(employeeUser, "EmployeeUser");
                }
            }
        }
    }
}
