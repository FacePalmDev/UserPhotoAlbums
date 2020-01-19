using System.Collections.Generic;

namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IUserService<T>
    {
        IEnumerable<T> Get();
     
    }
}
