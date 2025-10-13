using Application.Interfaces;

namespace Infrastructure.Services
{
    public class MapsterMapperAdapter : IMapper
    {
        private readonly MapsterMapper.IMapper _mapsterMapper;

        public MapsterMapperAdapter(MapsterMapper.IMapper mapsterMapper)
        {
            _mapsterMapper = mapsterMapper;
        }

        public TDestination Map<TDestination>(object source)
            => _mapsterMapper.Map<TDestination>(source);
    }
}
