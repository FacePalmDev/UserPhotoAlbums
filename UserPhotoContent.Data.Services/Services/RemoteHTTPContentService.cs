using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Contracts.Models;

namespace UserPhotoContent.Data.Services
{
    public class RemoteHttpContentService<TThirdPartyModel> : IRemoteContentService<TThirdPartyModel>
    where TThirdPartyModel : IThirdPartyModel
    {

        public virtual async Task<IEnumerable<TThirdPartyModel>> Get(Uri endpoint)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(endpoint);

            var apiResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<TThirdPartyModel>>(apiResponse);
        }
    }
}
