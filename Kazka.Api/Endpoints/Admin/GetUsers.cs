using Microsoft.AspNetCore.Http;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Responces;
using Kazka.Api.Extensions;
using Kazka.Application.Interfaces.Services;
using Domain.Entities;

namespace Kazka.Api.Endpoints.Admin
{
    [AdminEndpoint]
    [EndpointVersion(1)]
    public class GetUsers : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("users",
                async (
                    IUserBusinessLogic userBusinessLogic
                ) =>
            {
                var result = await userBusinessLogic.GetUsersAsync();

                if (result.IsFailure)
                    return result.ToActionResult<List<User>, List<UserResponce>>();

                return result.ToActionResult(users =>
                    users.Select(user => new UserResponce
                    {
                        Id = user.Id,
                        Role = user.Role,
                        Age = user.Age,
                        Name = user.UserName,
                        Email = user.Email,
                        ProfilePictureUrl = user.ProfilePictureUrl
                    }).ToList());
            });
        }
    }
}
