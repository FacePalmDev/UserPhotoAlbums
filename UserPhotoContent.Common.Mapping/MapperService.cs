using AutoMapper;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Common.Mapping.Profiles;

namespace UserPhotoContent.Common.Mapping
{
    public class MapperService : IMapperService
    {
        private readonly IMapper _mapper;

        public MapperService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PhotoAlbumProfile>();
            });

            _mapper = new Mapper(config);
        }

        public TDest Map<TDest>(object source)
        {
            return _mapper.Map<TDest>(source);
        }
    }
}