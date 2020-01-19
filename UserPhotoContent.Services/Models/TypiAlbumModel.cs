using UserPhotoContent.Data.Contracts.Models;

namespace UserPhotoContent.typicode.Models
{
    public class TypiAlbumModel : IThirdPartyModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
