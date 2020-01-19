using System.Collections.Generic;
using UserPhotoContent.Interfaces.Services;
using UserPhotoContent.typicode.Photos;


namespace UserPhotoContent.Api.Services.PhotoAlbum.typicode
{
    public class TypiCodePhotoService: IService<TypiPhotoModel>
    {
        private readonly IRemoteContentService _remoteApiService;

        public TypiCodePhotoService(IRemoteContentService remoteApiService)
        {
            _remoteApiService = remoteApiService;
        }

        public IEnumerable<TypiPhotoModel> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
