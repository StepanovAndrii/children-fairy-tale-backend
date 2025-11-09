using Kazka.Application.Results;

namespace Kazka.Api.Extensions
{
    public static class ResultExtensions
    {
        public static IResult ToActionResult<T, TDto>(
                this Result<T> result,
                Func<T, TDto>? mapToDto = null
            )
        {
            if (result.IsFailure)
            {
                return Results.Problem(
                    result.Error!.ErrorMessage,
                    statusCode: (int)result.Error.ErrorType
                );
            }

            if (result.SuccessResult is null || result.SuccessResult.Value is null)
                return Results.StatusCode(
                    (int)(result.SuccessResult?.Type ?? SuccessType.NoContent)
                );

            var value = result.SuccessResult.Value;

            object? response = mapToDto is not null
                ? mapToDto(value!)
                : (object?)value;

            return Results.Json(
                    response,
                    statusCode: (int)result.SuccessResult.Type
                );
        }
    }
}
