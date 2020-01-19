using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodeAlbumService: IUserService<TypiAlbumModel>
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
