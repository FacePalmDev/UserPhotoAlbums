using System;

namespace UserPhotoContent.Interfaces.Models
{
    public interface IPhotoDomainModel: IDomainModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
