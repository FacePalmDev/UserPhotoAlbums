using System;
using System.Collections.Generic;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Interfaces.Services
{
    public interface IRemoteContentService
    {
        IEnumerable<IDomainModel> Get(Uri endpoint);
    }
}