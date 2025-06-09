using HelpApp.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace HelpApp.Infra.Data.Identity
{
    internal class SeedUserRoleInitial : ISeedUserRoleInitial

    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            roleManager = roleManager;
        }

        public void SeedRoles() 
        {
           if(_userManager.FindByEmailAsync("usuarioLocalhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "usuarioLocalhost";
                user.Email = "usuarioLocalhost";
                user.NormalizedUserName = "USUARIOLOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp= Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Fatec@297").Result;

                if(result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

            if (_userManager.FindByEmailAsync("usuarioLocalhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "usuarioLocalhost";
                user.Email = "usuarioLocalhost";
                user.NormalizedUserName = "USUARIOLOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Fatec@297").Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

        }

        public void SeedUsers()
        {
            if (!_roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();

                role.Name = "user";
                role.NormalizedName = "USER";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }

            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();

                role.Name = "user";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }
    }
}
