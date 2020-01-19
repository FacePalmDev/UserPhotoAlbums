using System.Collections.Generic;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Interfaces.Services
{
    public interface IUserContentService
    {
        IEnumerable<IDomainModel> Get(int userId);
    }
}