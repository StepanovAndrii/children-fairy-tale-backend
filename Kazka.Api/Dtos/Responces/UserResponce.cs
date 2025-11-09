using Domain.Enums;

namespace Kazka.Api.Dtos.Responces
{
    public class UserResponce
    {
        public required int Id { get; set; }
        public required UserRole Role { get; set; }
        public required byte? Age { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string? ProfilePictureUrl { get; set; }
    }
}
