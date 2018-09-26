using System;
using Microsoft.AspNetCore.Identity;
using ProjectManagementApp.Models;

public static class MyIdentityDataInitializer
{
    public static void SeedData (UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        SeedRoles(roleManager);
        SeedUsers(userManager);
    }

    public static void SeedUsers (UserManager<ApplicationUser> userManager)
    {
        if (userManager.FindByNameAsync("Admin").Result == null)
    {
        ApplicationUser user = new ApplicationUser();
        user.UserName = "admin@example.com";
        user.Email = "admin@example.com";

        IdentityResult result = userManager.CreateAsync
        (user, "Password1!").Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(user, "Administrator").Wait();
        }
    }
    }

    public static void SeedRoles (RoleManager<IdentityRole> roleManager)
    {
        if (!roleManager.RoleExistsAsync("Administrator").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Administrator";
            IdentityResult roleResult = roleManager.CreateAsync(role).Result;
        }
    }
}