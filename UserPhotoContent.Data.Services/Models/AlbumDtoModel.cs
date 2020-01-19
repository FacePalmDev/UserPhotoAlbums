using System;
using UserPhotoContent.Common.Contracts.Models;

namespace UserPhotoContent.Data.Models
{
    public class AlbumDtoModel : IDtoModel
    {
        protected bool Equals(AlbumDtoModel other)
        {
            return Id == other.Id && UserId == other.UserId && Title == other.Title;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((AlbumDtoModel) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UserId, Title);
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }


        public static bool operator ==(AlbumDtoModel obj1, AlbumDtoModel obj2)
        {
            return
                obj1?.Id == obj2?.Id &&
                obj1?.Title == obj2?.Title &&
                obj1?.UserId == obj2?.UserId;
        }

        public static bool operator !=(AlbumDtoModel obj1, AlbumDtoModel obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
