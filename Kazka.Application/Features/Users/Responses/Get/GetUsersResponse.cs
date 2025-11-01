using Domain.Entities;
using System.Collections.Immutable;
using static Kazka.Application.Features.Book.Command.Add.AddStoryCommand;

namespace Kazka.Application.Features.Users.Responses.Get
{
    public record GetUsersResponse
        (
            ImmutableList<UserResponse> Users
        )
    {
        public GetUsersResponse
            (
                IEnumerable<UserResponse> users
            ): this(users.ToImmutableList())
        {

        }

        public virtual bool Equals(GetUsersResponse? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Users.SequenceEqual(other.Users);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();

            foreach (var user in Users)
            {
                hash.Add(user);
            }

            return hash.ToHashCode();
        }
    }
}
