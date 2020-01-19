using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.Data.Models;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodePhotoService: IThirdPartyService<PhotoDtoModel>
    {
        private readonly IMapperService _mapperService;
        private readonly IRemoteContentService<TypiPhotoModel> _remoteApiService;

        // todo hard coded string
        private readonly Uri _tapiCodePhotosUrl = new Uri("http://jsonplaceholder.typicode.com/photos");
        public TypiCodePhotoService(IMapperService mapperService, IRemoteContentService<TypiPhotoModel> remoteApiService)
        {
            _mapperService = mapperService;
            _remoteApiService = remoteApiService;
        }

        public IEnumerable<PhotoDtoModel> Get()
        {
            return
                _mapperService.Map<IEnumerable<PhotoDtoModel>>(
                    _remoteApiService.Get(_tapiCodePhotosUrl).Result);
        }
    }
}
