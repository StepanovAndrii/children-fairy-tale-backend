using System.Security.Cryptography;
using System.Text;

namespace Kazka.Application.BusinessLogic.Utils
{
    public static class TokenUtils
    {
        public static string GenerateRefreshToken(int size = 64)
        {
            var bytes = RandomNumberGenerator.GetBytes(size);
            return Convert.ToBase64String(bytes);
        }

        public static string ComputeSha256HashBase64(string token)
        {
            var bytes = Encoding.UTF8.GetBytes(token);
            using var sha = SHA256.Create();
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool FixedTimeEqualsBase64(string aBase64, string bBase64)
        {
            var a = Convert.FromBase64String(aBase64);
            var b = Convert.FromBase64String(bBase64);
            return CryptographicOperations.FixedTimeEquals(a, b);
        }
    }
}
