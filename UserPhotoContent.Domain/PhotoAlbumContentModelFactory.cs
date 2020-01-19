using UserPhotoContent.Interfaces.Factories;
using UserPhotoContent.Interfaces.Models;

namespace UserPhotoContent.Domain
{
    public class PhotoAlbumContentModelFactory : IFactory<IDomainModel>
    {
        public PhotoAlbumContentModelFactory()
        {
            
        }
        public IDomainModel Create()
        {
            throw new System.NotImplementedException();
        }
     
    }

}
