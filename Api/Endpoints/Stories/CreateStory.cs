using Api.Dtos.Story;
using Application.Features.Commands;
using Application.Interfaces.Internal;

namespace Api.Endpoints.Stories
{
    public static class CreateStory
    {
        public static void Map(WebApplication builder)
        {
            builder.MapPost(
                "/api/v1/stories",
                async (
                        CreateStoryDto storyDto,
                        IStoryService storyService
                    ) =>
                {
                    var createStoryCommand = new CreateStoryCommand
                    (
                        storyDto.Title,
                        storyDto.Description,
                        storyDto.CoverImageUrl,
                        storyDto.LanguageCode,
                        storyDto.Chapters.Select(
                            chapter => new CreateChapterCommand
                            (
                                chapter.SequenceNumber,
                                chapter.Title,
                                chapter.AudioUrl,
                                chapter.Paragraphs.Select(
                                    paragraph => new CreateParagraphCommand
                                    (
                                        paragraph.SequenceNumber,
                                        paragraph.Content,
                                        paragraph.IllustrationUrl,
                                        paragraph.StartTimeInMilliseconds,
                                        paragraph.EndTimeInMilliseconds
                                )).ToList()
                        )).ToList()
                    );

                    var createdStoryId = await storyService.CreateStoryAsync(
                        createStoryCommand
                    );

                    return Results.Created(
                        $"/api/v1/stories/{createdStoryId}",
                        new { Id = createdStoryId }
                    );
                }
            );
        }
    }
}
