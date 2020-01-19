namespace UserPhotoContent.Common.Contracts.Services
{
    public interface IMapperService
    {
        TDest Map<TDest>(object source);
    }
}
