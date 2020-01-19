using System.Collections.Generic;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Domain.Models
{
    public class AlbumModel : IAlbumDomainModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<IPhotoDomainModel> Photos { get; set;  }
    }
}
