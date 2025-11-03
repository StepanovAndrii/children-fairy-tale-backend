using Domain.ValueObjects;

namespace Kazka.Application.Features.Stories.Responses.Update
{
    public record UpdateStoryResponse
    (
        uint Id,
        string Title,
        string? Description,
        uint CategoryId,
        Url? CoverPath,
        uint LanguageId
    );
}
