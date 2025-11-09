using Domain.Enums;

namespace Kazka.Application.Requests.Commands
{
    public class UpdateUserRoleCommand
    {
        public required int Id { get; set; }
        public required UserRole Role { get; set; }
    }
}
