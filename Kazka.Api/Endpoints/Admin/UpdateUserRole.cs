using Domain.Entities;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Requests;
using Kazka.Api.Dtos.Responces;
using Kazka.Api.Extensions;
using Kazka.Application.Interfaces.Services;
using Kazka.Application.Requests.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.Admin
{
    [AdminEndpoint]
    [EndpointVersion(1)]
    public class UpdateUserRole : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapPatch("users/{id}/role",
                async (
                     [FromBody] UpdateUserRoleRequest request,
                     IUserBusinessLogic userBusinessLogic,
                     int id
                ) =>
            {
                var command = new UpdateUserRoleCommand
                {
                    Id = id,
                    Role = request.Role
                };

                var result = await userBusinessLogic.UpdateUserRoleAsync(command);

                return result.ToActionResult<User, UserResponce>(user =>
                    new UserResponce 
                    {
                        Id = user.Id,
                        Age = user.Age,
                        Role = user.Role,
                        Name = user.UserName,
                        Email = user.Email,
                        ProfilePictureUrl = user.ProfilePictureUrl
                    }
                );
            });
        }
    }
}
