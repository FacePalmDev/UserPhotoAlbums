using System.Collections.Generic;

namespace UserPhotoContent.Common.Contracts.Models
{
    public interface IAlbumDomainModel : IDomainModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        
    }
}
