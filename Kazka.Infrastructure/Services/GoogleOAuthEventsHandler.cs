using Application.Interfaces.Services;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Security.Claims;

namespace Infrastructure.Services
{
    public class GoogleOAuthEventsHandler : OAuthEvents
    {
        private readonly IAuthBusinessLogic _authBusinessLogic;
        public GoogleOAuthEventsHandler
            (
                IAuthBusinessLogic authBusinessLogic
            )
        {
            _authBusinessLogic = authBusinessLogic;
        }
        public override async Task CreatingTicket(
                OAuthCreatingTicketContext context
            )
        {
            try
            {
                var email = context.Principal?.FindFirstValue(ClaimTypes.Email);
                var googleId = context.Principal?.FindFirstValue(ClaimTypes.NameIdentifier);
                var pictureUrl = context.Principal?.FindFirstValue("pictureUrl");

                if (string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(googleId))
                {
                    // TODO: Add logging
                    context.Fail(""); // TODO: Add localization
                    return;
                }
                //if (await _authBusinessLogic.UserExistsAsync(googleId))
                //{
                //    context.Fail("");
                //    return;
                //}

                // TODO: user can return as null (realization as can't be null inside)
                //var user = await _authBusinessLogic.RegisterWithGoogleUserAsync
                //    (googleId,
                //    email,
                //    pictureUrl);

                //if (user is null)
                //{
                //    // TODO: Add logging
                //    context.Fail(""); // TODO: Add localization
                //    return;
                //}

                var identity = context.Principal!.Identity as ClaimsIdentity;
                //identity!.AddClaim(
                //    new Claim(ClaimTypes.Role, nameof(user.Role))
                //);
            }
            catch (Exception)
            {
                // TODO: Add logging
            }
        }
    }
}
