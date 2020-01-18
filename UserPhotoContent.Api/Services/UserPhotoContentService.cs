using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPhotoContent.Api.Models;

namespace UserPhotoContent.Api.Services
{
    public class UserPhotoContentService : IContentService
    {
        public IEnumerable<IContentModel> GetUserContent(int userId)
        {
           return new List<IContentModel>();
        }
    }
}
