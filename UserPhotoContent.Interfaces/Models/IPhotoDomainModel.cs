using System;

namespace UserPhotoContent.Common.Contracts.Models
{
    public interface IPhotoDomainModel: IDomainModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}
