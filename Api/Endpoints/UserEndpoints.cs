using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.Interfaces.Services;
using Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var profileGroup = group.MapGroup("/profile");

            profileGroup.MapGet("", GetUserInfo).RequireAuthorization();
            profileGroup.MapPatch("", UpdateUserInfo).RequireAuthorization();
        }

        private static IResult GetUserInfo(
                HttpContext context
            )
        {
            var user = context.User;

            if (user?.Identity is not { IsAuthenticated: true })
                return Results.Unauthorized();

            var email = user.FindFirstValue(ClaimTypes.Email);

            if (email == null)
                return Results.Unauthorized();

            var pictureUrl = user.FindFirstValue("pictureUrl");

            var userInfo = new UserInfoResponseDto(
                ProfilePictureUrl: pictureUrl,
                Email: email
            );

            return Results.Ok(userInfo);
        }

        private static async Task<IResult> UpdateUserInfo(
                PartialUpdateUserRequest request,
                [FromServices] HttpContext context,
                [FromServices] IOAuthService oAuthService,
                [FromServices] Application.Interfaces.IMapper mapper
            )
        {
            var userGoogleId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userGoogleId == null)
                return Results.Unauthorized();

            var user = await oAuthService.GetUserInfoAsync(userGoogleId);

            if (user == null)
                return Results.NotFound();

            if (request.ProfilePictureUrl != null)
                user.ProfilePictureUrl = new Url(request.ProfilePictureUrl);

            if (request.Name != null)
                user.Name = request.Name;

            if (request.Age != null)
                user.Age = request.Age;

            await oAuthService.UpdateUserAsync(user);

            return Results.Ok(
                mapper.Map<UserInfoResponseDto>(user)
            );
        }
    }
}
