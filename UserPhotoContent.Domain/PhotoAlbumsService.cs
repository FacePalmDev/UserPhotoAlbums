
using System;
using System.Collections.Generic;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Domain.Models;
using UserPhotoContent.Interfaces.Factories;
using UserPhotoContent.Interfaces.Models;
using UserPhotoContent.Interfaces.Services;


namespace UserPhotoContent.Domain
{
    public class PhotoAlbumsService : IUserContentService
    {
        private readonly IService<AlbumDtoModel> _albumSourceService;
        private readonly IService<PhotoDtoModel> _photoSourceService;
        private readonly IFactory<IDomainModel> _userContentFactory;

        public PhotoAlbumsService(
            IService<AlbumDtoModel> albumSourceService, 
            IService<PhotoDtoModel> photoSourceService,
            IFactory<IDomainModel> userContentFactory)
        {
            _albumSourceService = albumSourceService;
            _photoSourceService = photoSourceService;
            _userContentFactory = userContentFactory;
        }
        public IEnumerable<IDomainModel> Get(int userId)
        {

            throw new NotImplementedException();
            // var userAlbums = _albumSourceService.Get().Where(a => a.UserId == userId); 
            //
            // foreach (var album in userAlbums)
            // { 
            //     var albumPhotos = 
            //         _photoSourceService.Get()
            //         .Where(p => p.AlbumId == album.Id);
            //
            //     yield return _userContentFactory.Create();
            // } 

        }
    }


}
