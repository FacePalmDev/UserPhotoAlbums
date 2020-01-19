using System.Collections.Generic;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Data.Models
{
    public class AlbumDtoModel: IDtoModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<IPhotoDomainModel> Photos { get; set; }
    }
}
