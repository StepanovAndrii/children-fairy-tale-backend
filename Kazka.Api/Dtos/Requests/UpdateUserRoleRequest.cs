using Domain.Enums;
using System.Text.Json.Serialization;

namespace Kazka.Api.Dtos.Requests
{
    public class UpdateUserRoleRequest
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public required UserRole Role { get; set; }
    }
}
