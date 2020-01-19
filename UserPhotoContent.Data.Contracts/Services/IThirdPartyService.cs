using System.Collections.Generic;

namespace UserPhotoContent.Data.Contracts.Services
{
    public interface IThirdPartyService<TDtoModel> 
    { 
        IEnumerable<TDtoModel> Get();
    }
}
