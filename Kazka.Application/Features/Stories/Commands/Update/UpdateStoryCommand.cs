using Kazka.Application.Features.Stories.Responses.Update;
using MediatR;

namespace Kazka.Application.Features.Stories.Commands.Update
{
    public record UpdateStoryCommand
    (
        uint storyId,
        string? Title,
        string? Description,
        uint? CategoryId,
        string? CoverPath,
        uint? LanguageId
    ): IRequest<UpdateStoryResponse>;
}
