using Domain.Entities;

namespace Kazka.Core.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public required string HashedToken { get; set; }
        public required int UserId { get; set; }
        public required User User { get; set; }
        public DateTime Expires { get; set; }
        public bool IsRevoked { get; set; }
    }
}
