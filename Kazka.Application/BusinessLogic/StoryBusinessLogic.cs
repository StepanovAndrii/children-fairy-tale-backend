using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Application.Requests.Commands;
using Kazka.Application.Requests.Queries;
using Kazka.Application.Results;
using Kazka.Core;

namespace Application.Services
{
    public class StoryBusinessLogic: IStoryBusinessLogic
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly IStoryRepository _storyRepository;
        public StoryBusinessLogic
            (
                ICategoryRepository categoryRepository,
                ILanguageRepository languageRepository,
                IStoryRepository storyRepository

            )
        {
            _categoryRepository = categoryRepository;
            _languageRepository = languageRepository;
            _storyRepository = storyRepository;
        }

        public async Task<Result<Audio>> CreateAudioAsync(CreateAudioCommand command)
        {
            var chapter = await _storyRepository.GetChapterByIdAsync(command.ChapterId);
            if (chapter is null)
                return Result<Audio>.Failure(
                    $"Chapter with ID {command.ChapterId} was not found",
                    ErrorType.NotFound
                );
            // TODO: add url format check
            var audio = new Audio
            {
                AudioPath = command.AudioPath,
                Chapter = chapter
            };
            
            await _storyRepository.AddAudioAsync(audio);

            return Result<Audio>.Success(audio);
        }

        public async Task<Result<Unit>> DeleteAudioAsync(DeleteAudioCommand command)
        {
            await _storyRepository.DeleteAudioAsync(command.ChapterId);

            return Result<Unit>.Success(null, SuccessType.NoContent);
        }

        //public async Task<Result<IEnumerable<Story>>> GetAllStorySummariesAsync(GetStorySummaryQuery query)
        //{
            
        //}

        public async Task<Result<Audio>> GetAudioAsync(GetAudioQuery query)
        {
            var audio = await _storyRepository.GetAudioAsync(query.ChapterId);
            if (audio is null)
                return Result<Audio>.Failure(
                    $"Audio with ID {query.ChapterId} was not found",
                    ErrorType.NotFound
                );

            return Result<Audio>.Success
                (
                    audio,
                    SuccessType.Ok
                );
        }

        public async Task<Result<Audio>> UpdateAudioAsync(UpdateAudioCommand command)
        {
            var chapter = await _storyRepository.GetChapterByIdAsync(command.ChapterId);
            if (chapter is null)
                return Result<Audio>.Failure(
                    $"Chapter with ID {command.ChapterId} was not found",
                    ErrorType.NotFound
                );

            var audio = await _storyRepository.GetAudioAsync(command.ChapterId);
            if (audio is null)
                return Result<Audio>.Failure(
                    $"Audio with ID {command.ChapterId} was not found",
                    ErrorType.NotFound
                );

            if (command.AudioPath is not null)
                audio.AudioPath = command.AudioPath;

            await _storyRepository.UpdateAudioAsync(audio);

            return Result<Audio>.Success(audio, SuccessType.Ok);
        }
    }
}
