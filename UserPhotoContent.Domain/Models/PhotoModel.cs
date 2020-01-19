using System;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Domain.Models
{
    public class PhotoModel : IPhotoDomainModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
