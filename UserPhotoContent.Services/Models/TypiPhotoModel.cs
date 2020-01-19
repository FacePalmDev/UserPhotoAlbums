
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Data.Contracts.Models;

namespace UserPhotoContent.typicode.Models
{ 
    public class TypiPhotoModel: IThirdPartyModel
    {

        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }

    }
}
