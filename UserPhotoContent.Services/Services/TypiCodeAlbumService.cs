using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.Data.Models;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodeAlbumService: IThirdPartyService<AlbumDtoModel>
    {
        private readonly IMapperService _mapperService;
        readonly IRemoteContentService<TypiAlbumModel> _remoteContentService;
        
        // todo hard coded string
        private readonly Uri _tapiCodeAlbumsUrl = new Uri("http://jsonplaceholder.typicode.com/albums");
        public TypiCodeAlbumService(
            IMapperService mapperService,
            IRemoteContentService<TypiAlbumModel> remoteContentService)
        {
            _mapperService = mapperService;
            _remoteContentService = remoteContentService;
        }

        public IEnumerable<AlbumDtoModel> Get()
        {
            return
                _mapperService.Map<IEnumerable<AlbumDtoModel>>(
                _remoteContentService.Get(_tapiCodeAlbumsUrl).Result);
        }
    }
}
