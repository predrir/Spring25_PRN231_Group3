using MedicalWarehouse_BusinessObject.Entity;
using MedicalWarehouse_BusinessObject.Enums;
using MedicalWarehouse_BusinessObject.Response;
using MedicalWarehouse_Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MedicalWarehouse_Services.Services
{
    public class AuthServices : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _jwtSettings;
        private readonly ILogger<AuthServices> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AuthServices
            (
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<AuthServices> logger,
            IConfiguration configuration,
            TokenProvider tokenProvider
            )
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
/*            _jwtSettings = _configuration.GetSection("JWT:Secret");*/
            _configuration = configuration;
        }

        public async Task<LoginResponse> SeedRoles()
        {
            var isAdminRoleExists = await _roleManager.RoleExistsAsync(UserRoles.ADMIN);
            var isStaffRoleExists = await _roleManager.RoleExistsAsync(UserRoles.STAFF);
            var isPharmacyRoleExists = await _roleManager.RoleExistsAsync(UserRoles.PHARMACY);  

            if(isAdminRoleExists && isStaffRoleExists && isPharmacyRoleExists )
            {
                return new LoginResponse
                {
                    Success = true,
                    AccessToken = "Seed roles already",
                    ExpiredTime = 0,
                    RefreshToken = null
                };
            }

            await _roleManager.CreateAsync(new IdentityRole(UserRoles.ADMIN));
            await _roleManager.CreateAsync(new IdentityRole(UserRoles.STAFF));
            await _roleManager.CreateAsync(new IdentityRole(UserRoles.PHARMACY));

            return new LoginResponse
            {
                Success = true,
                AccessToken = "Seed roles successfully",
                ExpiredTime = 0,
                RefreshToken = null
            };
        }
    }
}
