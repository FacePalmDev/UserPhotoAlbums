using System.Collections.Generic;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Data.Models
{
    public class AlbumDtoModel: IDtoModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

    }
}
