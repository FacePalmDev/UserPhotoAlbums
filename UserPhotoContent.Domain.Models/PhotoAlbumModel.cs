using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Domain.Models
{
    public class PhotoAlbumModel : IAlbumDomainModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<PhotoModel> Photos { get; set; }
    }
}
