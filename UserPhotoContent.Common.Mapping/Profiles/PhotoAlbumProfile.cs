using System;
using System.Collections.Generic;
using System.Text;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Data.Models;
using AutoMapper;
using UserPhotoContent.Domain.Models;


namespace UserPhotoContent.Common.Mapping.Profiles
{
    public class PhotoAlbumProfile : Profile
    {
        public PhotoAlbumProfile()
        {
            CreateMap<PhotoDtoModel, PhotoModel>().ReverseMap();
            CreateMap<AlbumDtoModel, AlbumModel>().ReverseMap();
        }

    }
}
