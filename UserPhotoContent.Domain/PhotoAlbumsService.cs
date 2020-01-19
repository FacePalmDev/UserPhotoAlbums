using System.Collections.Generic;
using System.Linq;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Domain.Models;

namespace UserPhotoContent.Domain.Services
{
    public class PhotoAlbumsService : IUserContentService<PhotoAlbumModel>
    {
        private readonly IThirdPartyService<AlbumDtoModel> _albumSourceService;
        private readonly IThirdPartyService<PhotoDtoModel> _photoSourceService;
        private readonly IMapperService _mapperService;

        public PhotoAlbumsService(
            IThirdPartyService<AlbumDtoModel> albumSourceService, 
            IThirdPartyService<PhotoDtoModel> photoSourceService,
            IMapperService mapperService)
        {
            _albumSourceService = albumSourceService;
            _photoSourceService = photoSourceService;
            _mapperService = mapperService;
        }
        public IEnumerable<PhotoAlbumModel> Get(int userId)
        {
            var albumDtoModels = 
                _albumSourceService.Get()
                    .Where(a => a.UserId == userId);

            var albumDomainModels = _mapperService.Map<IEnumerable<PhotoAlbumModel>>(albumDtoModels);

            foreach (var album in albumDomainModels)
            {
                var albumPhotoDtoModels =
                    _photoSourceService.Get()
                        .Where(p => p.AlbumId == album.Id);

                var albumPhotoDomainModels = _mapperService.Map<IEnumerable<PhotoModel>>(albumPhotoDtoModels);

                album.Photos = albumPhotoDomainModels;
                
                yield return album;

            } 
        }
    }


}
