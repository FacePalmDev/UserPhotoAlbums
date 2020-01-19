using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IUserContentService
    {
        IEnumerable<IDomainModel> Get(int userId);
    }
}