using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.typicode.Models;

namespace UserPhotoContent.typicode.Services
{
    public class TypiCodeAlbumService
    {
        readonly IRemoteContentService<TypiAlbumModel> _remoteContentService;
        
        // todo hard coded string
        private readonly Uri _tapiCodeAlbumsUrl = new Uri("http://jsonplaceholder.typicode.com/albums");
        public TypiCodeAlbumService(IRemoteContentService<TypiAlbumModel> remoteContentService)
        {
            _remoteContentService = remoteContentService;
        }

        public IEnumerable<TypiAlbumModel> Get()
        {
            return _remoteContentService.Get(_tapiCodeAlbumsUrl).Result;
        }
    }
}
