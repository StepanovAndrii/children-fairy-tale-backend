using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class User
    {
        public uint Id { get; private set; }
        public string GoogleId { get; private set; } = null!;
        public UserRole Role { get; private set; }
        public byte? Age { get; private set; }
        public string Name { get; private set; } = null!;
        public Email Email { get; private set; } = null!;
        public string NormalizedEmail { get; private set; } = null!;
        public Url? ProfilePictureUrl { get; private set; }
        // TODO: develop soft delete
        //public bool IsDeleted { get; private set; }
        //public DateTime DeletedAt { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public ICollection<Like> Likes { get; private set; } = new HashSet<Like>();
        private User() { }

        public static User Create
            (
                string googleId,
                Email email,
                Url? ProfilePictureUrl = null
            )
        {
            return new User
            {
                GoogleId = googleId,
                Role = UserRole.User,
                Name = email.Normalized.Split('@')[0],
                Email = email,
                NormalizedEmail = email.Normalized,
                ProfilePictureUrl = ProfilePictureUrl,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
        //public void Delete()
        //{
        //    DeletedAt = DateTime.UtcNow;
        //    IsDeleted = true;
        //    Touch();
        //}
        public void UpdateProfilePictureUrl
            (
                string profilePictureUrl
            )
        {
            ProfilePictureUrl = new Url(profilePictureUrl);
            // TODO: add result object
            Touch();
        }
        public void UpdateName
            (
                string name
            )
        {
            Name = name;
            Touch();
        }
        public void UpdateAge
            (
                byte age
            )
        {
            Age = age;
            Touch();
        }

        public void UpdateRole
            (
                UserRole role
            )
        {
            Role = role;
            Touch();
        }

        private void Touch()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
