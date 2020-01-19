
using System;
using System.Collections.Generic;
using System.Linq;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Domain.Models;


namespace UserPhotoContent.Domain
{
    public class PhotoAlbumsService : IUserContentService
    {
        private readonly IUserService<AlbumDtoModel> _albumSourceService;
        private readonly IUserService<PhotoDtoModel> _photoSourceService;
        private readonly IMapperService _mapperService;

        public PhotoAlbumsService(
            IUserService<AlbumDtoModel> albumSourceService, 
            IUserService<PhotoDtoModel> photoSourceService,
            IMapperService mapperService)
        {
            _albumSourceService = albumSourceService;
            _photoSourceService = photoSourceService;
            _mapperService = mapperService;
        }
        public IEnumerable<IDomainModel> Get(int userId)
        {
            var albumDtoModels = 
                _albumSourceService.Get()
                    .Where(a => a.UserId == userId);

            var albumDomainModels = _mapperService.Map<IEnumerable<AlbumModel>>(albumDtoModels);

            foreach (var album in albumDomainModels)
            {
                var albumPhotoDtoModels =
                    _photoSourceService.Get()
                        .Where(p => p.AlbumId == album.Id);

                var albumPhotoDomainModels = _mapperService.Map<IEnumerable<PhotoModel>>(albumPhotoDtoModels);


                // album.Photos = albumPhotoDomainModels;


                yield return album;
                //
                // var albumPhotoDomainModels = new List<IPhotoDomainModel>();
                //




                // foreach (var photo in albumPhotos)
                // {
                //     albumPhotoDomainModels.Add(new PhotoModel()
                //     {
                //
                //     });
                // }
                //
                //
                // yield return new AlbumModel()
                // {
                //     Photos = 
                // }
            } 

        }
    }


}
