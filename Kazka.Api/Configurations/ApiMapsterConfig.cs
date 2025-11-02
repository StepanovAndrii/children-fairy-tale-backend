using Api.DTOs.Story.Requests.CreateStory;
using Api.DTOs.User.Requests;
using Kazka.Api.DTOs.User.Responses;
using Kazka.Application.Features.Book.Command.Add;
using Kazka.Application.Features.User.Command.Update;
using Kazka.Application.Features.Users.Responses.Get;
using Mapster;

namespace Kazka.Api.Configurations
{
    public class ApiMapsterConfig : IRegister
    {
        public void Register
            (
                TypeAdapterConfig config
            )
        {
            // ---- DTOs -> Commands & Queries ----
            config.NewConfig<CreateStoryRequestDto, AddStoryCommand>();
            config.NewConfig<CreateStoryRequestDto.ChapterDto, AddStoryCommand.ChapterRequest>();
            config.NewConfig<CreateStoryRequestDto.ParagraphDto, AddStoryCommand.ParagraphRequest>();

            config.NewConfig<UpdateUserRequestDto, UpdateUserCommand>();

            // ---- Commands & Queries -> DTOs ----
            config.NewConfig<GetUsersResponse, UsersResponseDto>();
        }
    }
}
