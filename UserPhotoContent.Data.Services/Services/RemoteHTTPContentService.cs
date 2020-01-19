using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;

namespace UserPhotoContent.Data.Services
{
    public class RemoteHttpContentService : IRemoteContentService
    {

        public IEnumerable<IDomainModel> Get(Uri endpoint)
        {
            throw new NotImplementedException();
            return null;
        }   
    }
}
