using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Models;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Clients
{
    public interface IResourceClient
    {
        Task<ResourceInfo> Info();
        System.Threading.Tasks.Task Delete(long id);
        Task<object?> Find(long id);
        Task<object?> this[long id] { get; }
    }

    public interface IResourceClient<TRes> : IResourceClient, IQueryableResource<TRes>
        where TRes : IResource, new()
    {
        Task<IEnumerable<TRes>> Query(Query query);
        System.Threading.Tasks.Task Bulk();
        new Task<TRes?> Find(long id);
        new Task<TRes?> this[long id] { get; }
    }

    internal class ResourceClient : IResourceClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _resourceName;

        public ResourceClient(HttpClient httpClient, string resourceName)
        {
            _httpClient = httpClient;
            _resourceName = resourceName;
        }

        Task<object?> IResourceClient.this[long id] => throw new NotImplementedException();

        System.Threading.Tasks.Task IResourceClient.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<object?> IResourceClient.Find(long id)
        {
            throw new NotImplementedException();
        }

        async Task<ResourceInfo> IResourceClient.Info()
        {
            var response = await _httpClient.GetAsync($"/api/v1/resource/{_resourceName}/INFO");
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ResourceInfo>(body)!;
        }
    }

    internal class ResourceClient<TRes> : ResourceClient, IResourceClient<TRes>
        where TRes : IResource, new()
    {
        private HttpClient _httpClient;

        public ResourceClient(HttpClient httpClient) : base(httpClient, typeof(TRes).Name)
        {
            _httpClient = httpClient;
        }

        public Task<TRes?> this[long id] => throw new NotImplementedException();

        public System.Threading.Tasks.Task Bulk()
        {
            throw new NotImplementedException();
        }

        public Task<TRes?> Find(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryableResource<TRes> Include<TJoinRes>(Expression<Func<TRes, Join<TJoinRes>?>> predicate) where TJoinRes : IResource, new()
        {
            throw new NotImplementedException();
        }

        public IQueryableResource<TRes> Include<TAssocRes>(Expression<Func<TRes, Assoc<TAssocRes>?>> predicate) where TAssocRes : IResource, new()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TRes>> Query(Query query)
        {
            throw new NotImplementedException();
        }

        public List<TRes> ToList()
        {
            throw new NotImplementedException();
        }

        public Query ToQuery()
        {
            throw new NotImplementedException();
        }

        public IQueryableResource<TRes> Where(Expression<Func<TRes, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
