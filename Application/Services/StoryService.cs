using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.ValueObjects;
using System.Collections;

namespace Application.Services
{
    public class StoryService: IStoryService
    {
        IStoryRepository _storyRepository;
        IChapterRepository _chapterRepository;
        ILanguageRepository _languageRepository;

        public StoryService(
                IStoryRepository storyRepository,
                IChapterRepository chapterRepository,
                ILanguageRepository languageRepository
            )
        {
            _storyRepository = storyRepository;
            _chapterRepository = chapterRepository;
            _languageRepository = languageRepository;
        }

        public Task<Chapter?> GetChapterByIdAsync(int chapterId)
        {
            return _chapterRepository.GetChapterByIdAsync(chapterId);
        }

        public async Task<IEnumerable<Story>> GetStoriesAsync
            (
                int? offset = null,
                int? limit = null,
                int? categoryId = null
            )
        {
            return await _storyRepository.GetStoriesAsync(limit, offset, categoryId);
        }

        public async Task<Story?> GetStoryByIdAsync(int storyId)
        {
            return await _storyRepository.GetStoryByIdAsync(storyId);
        }

        public async Task<Story> CreateStoryAsync(StoryCreateDto storydto)
        {
            var languageCode = new LanguageCode(storydto.LanguageCode);
            var language = await _languageRepository.GetLanguageByCodeAsync(languageCode);

            if (language is null)
            {
                throw new Exception($"Language with code {storydto.LanguageCode} not found");
            }

            var category = await _storyRepository.GetCategoryByNameAsync(storydto.Category);

            if (category is null)
            {
                throw new Exception($"Category with name {storydto.Category} not found");
            }

            Console.WriteLine(category.Name);

            var chapters = new List<Chapter>();

            foreach (var chapterDto in storydto.Chapters)
            {
                var pahagraphs = new List<Paragraph>();

                foreach (var paragraphDto in chapterDto.Paragraphs)
                {
                    pahagraphs.Add(
                        new Paragraph
                        {
                            OrderNumber = paragraphDto.OrderNumber,
                            Text = paragraphDto.Text,
                            ImageUrl = new Url(paragraphDto.ImageUrl),
                            StartTimeMs = paragraphDto.StartTimeMs,
                            EndTimeMs = paragraphDto.EndTimeMs
                        }
                    );
                }

                var audio = chapterDto.Audio is not null
                    ? new Audio
                    {
                        AudioUrl =
                            new Url(chapterDto.Audio.AudioUrl)
                    }
                    : null;
                
                chapters.Add(new Chapter
                {
                    Number = chapterDto.Number,
                    Audio = audio,
                    Paragraphs = pahagraphs
                });
            }

            var story = new Story
            {
                Title = storydto.Title,
                Description = storydto.Description,
                CoverPath = storydto.CoverPath is not null ? new Url(storydto.CoverPath) : null,
                Language = language,
                Likes = new List<Like>(),
                Chapters = chapters,
                Category = category
            };

            return await _storyRepository.CreateStoryAsync(story);
        }

        public async Task DeleteStoryAsync(int storyId)
        {
            var story = await _storyRepository.GetStoryByIdAsync(storyId);

            if (story is null)
            {
                throw new Exception($"Story with id {storyId} not found");
            }

            _storyRepository.DeleteStory(story);
        }
    }
}
