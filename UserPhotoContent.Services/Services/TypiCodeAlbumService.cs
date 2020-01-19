using System.Collections;
using System.Collections.Generic;
using UserPhotoContent.Interfaces.Services;

namespace UserPhotoContent.typicode.Albums
{
    public class TypiCodeAlbumService: IService<TypiAlbumModel>
    {
        readonly IRemoteContentService _remoteContentService;
        public TypiCodeAlbumService(IRemoteContentService remoteContentService)
        {
            _remoteContentService = remoteContentService;
        }


        public IEnumerable<TypiAlbumModel> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
