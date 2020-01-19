using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodePhotoService: IThirdPartyService<TypiPhotoModel>
    {
        private readonly IRemoteContentService<TypiPhotoModel> _remoteApiService;
        
        // todo hard coded string
        private readonly Uri _tapiCodePhotosUrl = new Uri("http://jsonplaceholder.typicode.com/photos");
        public TypiCodePhotoService(IRemoteContentService<TypiPhotoModel> remoteApiService)
        {
            _remoteApiService = remoteApiService;
        }

        public IEnumerable<TypiPhotoModel> Get()
        {
            return _remoteApiService.Get(_tapiCodePhotosUrl).Result;
        }
    }
}
