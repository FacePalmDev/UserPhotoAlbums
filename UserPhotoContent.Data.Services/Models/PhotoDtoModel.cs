using System;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Data.Models
{
    public class PhotoDtoModel: IDtoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
    