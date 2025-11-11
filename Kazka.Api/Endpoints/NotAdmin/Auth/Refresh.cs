using Kazka.Api.Attributes;
using Kazka.Application.Interfaces.External;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Auth
{
    [EndpointVersion(1)]
    public class Refresh : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            
        }
    }
}
