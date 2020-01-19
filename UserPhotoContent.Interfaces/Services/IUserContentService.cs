using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IUserContentService<T> where T : IDomainModel
    {
        IEnumerable<T> Get(int userId);
    }
}