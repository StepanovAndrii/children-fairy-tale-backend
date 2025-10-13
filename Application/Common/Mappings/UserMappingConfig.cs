using Application.DTOs.Responses;
using Domain.Entities;
using Mapster;

namespace Application.Common.Mappings
{
    public class UserMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<User, UserInfoResponseDto>()
                .Map(dest => dest.Email, src => src.Email.Value)
                .Map(dest => dest.ProfilePictureUrl,
                    src => src.ProfilePictureUrl != null ? src.ProfilePictureUrl.Value : null);
        }
    }
}
