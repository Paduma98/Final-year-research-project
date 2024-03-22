using EP_System_Test.Data.Static;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

            
            }


        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                //Admin
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                //User
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //School
                if (!await roleManager.RoleExistsAsync(UserRoles.School))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.School));

                //Teacher
                if (!await roleManager.RoleExistsAsync(UserRoles.Teacher))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Teacher));

                //Student
                if (!await roleManager.RoleExistsAsync(UserRoles.Student))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Student));


                //Users

                //Admin
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@ep.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FirstName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                //User
                string appUserEmail = "user@ep.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FirstName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

                //School
                string appSchoolUserEmail = "school@ep.com";

                var appSchoolUser = await userManager.FindByEmailAsync(appSchoolUserEmail);
                if (appSchoolUser == null)
                {
                    var newAppSchoolUser = new ApplicationUser()
                    {
                        FirstName = "School",
                        UserName = "app-user-doctor",
                        Email = appSchoolUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppSchoolUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppSchoolUser, UserRoles.School);
                }

                //Teacher
                string appTeacherUserEmail = "teacher@ep.com";

                var appPharmacistUser = await userManager.FindByEmailAsync(appTeacherUserEmail);
                if (appPharmacistUser == null)
                {
                    var newAppTeacherUser = new ApplicationUser()
                    {
                        FirstName = "Application User",
                        UserName = "app-user-pharmacist",
                        Email = appTeacherUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppTeacherUser, "Ep@1234?");
                    await userManager.AddToRoleAsync(newAppTeacherUser, UserRoles.Teacher);
                }

                //Student
                string appStudentUserEmail = "student@ep.com";

                var appStudentUser = await userManager.FindByEmailAsync(appStudentUserEmail);
                if (appStudentUser == null)
                {
                    var newAppStudentUser = new ApplicationUser()
                    {
                        FirstName = "Application User",
                        UserName = "app-user-dperson",
                        Email = appStudentUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppStudentUser, "Ep@1234?");
                    await userManager.AddToRoleAsync(newAppStudentUser, UserRoles.Student);
                }


            }
        }

    }
}