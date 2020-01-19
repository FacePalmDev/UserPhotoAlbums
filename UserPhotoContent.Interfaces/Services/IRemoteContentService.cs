using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Data.Contracts.Models;

namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IRemoteContentService<TThirdPartyModel> where TThirdPartyModel : IThirdPartyModel 
    {
        Task<IEnumerable<TThirdPartyModel>> Get(Uri endpoint);
    }
}