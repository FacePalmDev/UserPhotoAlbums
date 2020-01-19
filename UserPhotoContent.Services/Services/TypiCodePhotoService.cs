using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodePhotoService: IUserService<TypiPhotoModel>
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
