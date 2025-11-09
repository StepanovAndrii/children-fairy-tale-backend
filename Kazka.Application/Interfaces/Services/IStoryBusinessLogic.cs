using Domain.Entities;
using Kazka.Application.Requests.Commands;
using Kazka.Application.Requests.Queries;
using Kazka.Application.Results;
using Kazka.Core;

namespace Application.Interfaces.Services
{
    public interface IStoryBusinessLogic
    {
        //Task<Result<IEnumerable<Story>>> GetAllStorySummariesAsync(GetStorySummaryQuery query);
        Task<Result<Audio>> CreateAudioAsync(CreateAudioCommand command);
        Task<Result<Unit>> DeleteAudioAsync(DeleteAudioCommand command);
        Task<Result<Audio>> GetAudioAsync(GetAudioQuery query);
        Task<Result<Audio>> UpdateAudioAsync(UpdateAudioCommand command);
    }
}
