using System.Collections;
using System.Collections.Generic;

namespace UserPhotoContent.Interfaces.Services
{
    public interface IService<T>
    {
        IEnumerable<T> Get();
    }
}
