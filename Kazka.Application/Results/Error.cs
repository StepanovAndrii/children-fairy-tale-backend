namespace Kazka.Application.Results
{
    public enum ErrorType
    {
        Unauthorized = 401,
        NotFound = 404
    }
    public class Error
    {
        public string ErrorMessage { get; init; }
        public ErrorType ErrorType { get; init; }
        private Error
            (
                ErrorType errorType,
                string errorMessage
            )
        {
            ErrorMessage = errorMessage;
            ErrorType = errorType;
        }

        public static Error Create(ErrorType errorType, string errorMessage)
            => new Error(errorType, errorMessage);
    }
}
