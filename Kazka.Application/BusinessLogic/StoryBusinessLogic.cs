using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.ValueObjects;
using Kazka.Application.Features.Book.Command.Add;
using MapsterMapper;

namespace Application.Services
{
    public class StoryBusinessLogic: IStoryBusinessLogic
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly IStoryRepository _storyRepository;
        private readonly IMapper _mapper;
        public StoryBusinessLogic
            (
                ICategoryRepository categoryRepository,
                ILanguageRepository languageRepository,
                IStoryRepository storyRepository,
                IMapper mapper

            )
        {
            _categoryRepository = categoryRepository;
            _languageRepository = languageRepository;
            _storyRepository = storyRepository;
            _mapper = mapper;
        }

        public async Task<Story> CreateStoryAsync
            (
                AddStoryCommand request
            )
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            // TODO: add result object return
            // ?? return Result...

            var language = await _languageRepository.GetByIdAsync(request.LanguageId);
            // TODO: add result object return
            // ?? return Result...

            Url? coverPath = string.IsNullOrWhiteSpace(request.CoverPath)
                ? null
                : new Url(request.CoverPath);

            var story = Story.Create
                (
                    request.Title,
                    category,
                    language,
                    request.Description,
                    coverPath
                );

            foreach (var chapterRequest in request.Chapters)
            {
                var chapter = _mapper.Map<Chapter>(chapterRequest);
                story.AddChapter(chapter);
            }

            await _storyRepository.AddAsync(story);

            return story;
        }

        public async Task<IEnumerable<Story>> GetAllStories()
        {
            return await _storyRepository.GetAllAsync();
        }
    }
}
