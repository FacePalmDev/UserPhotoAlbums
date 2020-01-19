using UserPhotoContent.Data.Models;
using AutoMapper;
using UserPhotoContent.Domain.Models;
using UserPhotoContent.typicode.Models;


namespace UserPhotoContent.Common.Mapping.Profiles
{
    public class PhotoAlbumProfile : Profile
    {
        public PhotoAlbumProfile()
        {
            CreateMap<TypiAlbumModel, AlbumDtoModel>();
            CreateMap<TypiPhotoModel, PhotoDtoModel>();

            CreateMap<PhotoDtoModel, PhotoModel>();
            CreateMap<AlbumDtoModel, PhotoAlbumModel>();
        }

    }
}
