using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using BhpApp.Models;

namespace BhpApp.Data
{
    public class CustomSignInManager : SignInManager<Pracownik>
    {
        public CustomSignInManager(
            UserManager<Pracownik> userManager,
            IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<Pracownik> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<Pracownik>> logger,
            IAuthenticationSchemeProvider schemes,
            IUserConfirmation<Pracownik> confirmation)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
        {
        }

        public override async Task<bool> CanSignInAsync(Pracownik user)
        {
            if (user.CzyNaUrlopie)
            {
                return false;
            }

            return await base.CanSignInAsync(user);
        }
    }
}