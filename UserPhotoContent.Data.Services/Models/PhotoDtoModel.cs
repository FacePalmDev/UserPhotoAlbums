using System;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Data.Models
{
    public class PhotoDtoModel : IDtoModel
    {
        protected bool Equals(PhotoDtoModel other)
        {
            return Id == other.Id && Title == other.Title && Equals(Url, other.Url) && Equals(ThumbnailUrl, other.ThumbnailUrl) && AlbumId == other.AlbumId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PhotoDtoModel) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Url, ThumbnailUrl, AlbumId);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
        public int AlbumId { get; set; }

        public static bool operator ==(PhotoDtoModel obj1, PhotoDtoModel obj2)
        {
            return
                obj1?.Id == obj2?.Id &&
                obj1?.Title == obj2?.Title &&
                obj1?.Url == obj2?.Url &&
                obj1?.ThumbnailUrl == obj2?.ThumbnailUrl &&
                obj1?.AlbumId == obj2?.AlbumId;
        }

        public static bool operator !=(PhotoDtoModel obj1, PhotoDtoModel obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
