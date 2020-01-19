using System;
using System.Collections.Generic;
using UserPhotoContent.Interfaces.Models;
using UserPhotoContent.Interfaces.Services;

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
