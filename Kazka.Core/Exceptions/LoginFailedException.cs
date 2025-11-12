namespace Kazka.Core.Exceptions
{
    public class LoginFailedException(string email) : Exception($"User with email: {email} is not found.")
    {

    }
}
