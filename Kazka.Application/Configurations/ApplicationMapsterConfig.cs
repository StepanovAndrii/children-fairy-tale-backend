using Domain.Entities;
using Domain.ValueObjects;
using Kazka.Application.Features.Book.Command.Add;
using Kazka.Application.Features.Users.Responses;
using Mapster;

namespace Kazka.Application.Configurations
{
    public class ApplicationMapsterConfig : IRegister
    {
        public void Register
            (
                TypeAdapterConfig config
            )
        {
            config.NewConfig<AddStoryCommand.ChapterRequest, Chapter>()
                .IgnoreNonMapped(true);
            config.NewConfig<AddStoryCommand.ParagraphRequest, Paragraph>()
                .IgnoreNonMapped(true);

            config.NewConfig<User, UserResponse>()
                .Map(dest => dest.Role, src => src.Role.ToString())
                .ConstructUsing(src => new UserResponse
                (
                    src.Id,
                    src.Name,
                    src.Age,
                    src.Role.ToString(),
                    src.ProfilePictureUrl == null ? null : src.ProfilePictureUrl.Value
                ))
                .IgnoreNonMapped(true);
        }
    }
}
