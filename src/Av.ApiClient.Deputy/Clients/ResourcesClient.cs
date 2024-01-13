using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Clients
{
    public partial interface IResourcesClient
    {
        IResourceClient<TRes> Resource<TRes>()
            where TRes : IResource, new();

        IResourceClient Resource(string resourceName);
    }

    internal partial class ResourcesClient : IResourcesClient
    {
        private readonly HttpClient _httpClient;

        public ResourcesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IResourceClient Resource(string resourceName)
            => new ResourceClient(_httpClient, resourceName);

        public IResourceClient<TRes> Resource<TRes>()
            where TRes : IResource, new()
            => new ResourceClient<TRes>(_httpClient);
    }
}
