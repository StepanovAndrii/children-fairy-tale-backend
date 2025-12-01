using Application.Features.Commands;
using Application.Interfaces.Internal;
using Application.Interfaces.Internal.Repositories;
using Domain.Entities;

namespace Application.Services
{
    public class StoryService : IStoryService
    {
        private readonly IStoryRepository _repository;
        public StoryService(
                IStoryRepository repository
            ) {
            _repository = repository;
        }

        public async Task<Guid> CreateStoryAsync(CreateStoryCommand command)
        {
            var story = new Story{
                Id = Guid.NewGuid(),
                Title = command.Title,
                Description = command.Description,
                CoverImageUrl = command.CoverImageUrl,
                LanguageCode = command.LanguageCode,
                Chapters = command.Chapters.Select(chapter => new Chapter{
                    Id = Guid.NewGuid(),
                    SequenceNumber = chapter.SequenceNumber,
                    Title = chapter.Title,
                    AudioUrl = chapter.AudioUrl,
                    Paragraphs = chapter.Paragraphs.Select(paragraph => new Paragraph{
                        Id = Guid.NewGuid(),
                        SequenceNumber = paragraph.SequenceNumber,
                        Content = paragraph.Content,
                        IllustrationUrl = paragraph.IllustrationUrl,
                        StartTimeInMilliseconds = paragraph.StartTimeInMilliseconds,
                        EndTimeInMilliseconds = paragraph.EndTimeInMilliseconds
                    }).ToList()
                }).ToList()
            };

            await _repository.AddAsync(story);

            return story.Id;
        }

        public async Task<List<Story>> GetStorySummariesAsync()
        {
            return await _repository.GetAll();
        }

        public async Task DeleteStoryAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<Paragraph>> GetParagraphsAsync(Guid chapterId)
        {
            return await _repository.GetParagraphsByChapterIdAsync(chapterId);
        }

        public async Task<List<Chapter>> GetChapterSummariesAsync(Guid storyId)
        {
            return await _repository.GetChapterSummariesByStoryIdAsync(storyId);
        }
    }
}
