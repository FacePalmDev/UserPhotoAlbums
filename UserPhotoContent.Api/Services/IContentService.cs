using System.Collections.Generic;
using UserPhotoContent.Api.Models;

namespace UserPhotoContent.Api.Services
{
    public interface IContentService
    {
        IEnumerable<IContentModel> GetUserContent(int userId);
    }
}