using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Common.Mapping;
using UserPhotoContent.Data.Contracts.Services;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Data.Services;
using UserPhotoContent.Domain.Models;
using UserPhotoContent.Domain.Services;
using UserPhotoContent.typicode.Models;
using UserPhotoContent.typicode.Services;

namespace UserPhotoContent.Common.DependencyInjection
{
    public  static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddUserPhotoContentServices(this IServiceCollection services)
        {
            
            services.AddTransient<IMapperService, MapperService>();
            
            services.AddTransient<IUserContentService<PhotoAlbumModel>, PhotoAlbumsService>();
            services.AddTransient<IRemoteContentService<TypiAlbumModel>, RemoteHttpContentService<TypiAlbumModel>>();
            services.AddTransient<IRemoteContentService<TypiPhotoModel>, RemoteHttpContentService<TypiPhotoModel>>();
            services.AddTransient<IThirdPartyService<AlbumDtoModel>, TypiCodeAlbumService>();
            services.AddTransient<IThirdPartyService<PhotoDtoModel>, TypiCodePhotoService>();

            return services;

        }


    }
}
