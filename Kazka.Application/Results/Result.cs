namespace Kazka.Application.Results
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Success<T>? SuccessResult { get; }
        public Error? Error { get; }

        private Result
            (
                bool isSuccess,
                Success<T>? success,
                Error? error
            )
        {
            IsSuccess = isSuccess;
            SuccessResult = success;
            Error = error;
        }

        public static Result<T> Success(T? value, SuccessType type = SuccessType.Ok)
            => new Result<T>(true, Success<T>.Create(value, type), null);
        public static Result<T> Failure(string errorMessage, ErrorType errorType)
            => new Result<T>(false, null, Error.Create(errorType, errorMessage));
    }
}
