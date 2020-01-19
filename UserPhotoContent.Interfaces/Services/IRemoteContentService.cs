using System;
using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IRemoteContentService
    {
        IEnumerable<IDomainModel> Get(Uri endpoint);
    }
}