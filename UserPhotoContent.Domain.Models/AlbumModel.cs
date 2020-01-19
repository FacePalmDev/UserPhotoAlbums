using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Domain.Models
{
    public class AlbumModel : IAlbumDomainModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
    }
}
