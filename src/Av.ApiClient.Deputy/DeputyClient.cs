using System.Text.Json;
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Clients;

namespace Av.ApiClients.Deputy
{
    public interface IDeputyClient
    {
        IResourcesClient Resources { get; }
    }

    public class DeputyClient : IDeputyClient
    {
        private readonly HttpClient _httpClient;
        private readonly DeputyClientSettings _settings;

        private readonly Lazy<IResourcesClient> _resourcesClient;
        public IResourcesClient Resources => _resourcesClient.Value;

        public static readonly JsonSerializerOptions SerializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        public DeputyClient(HttpClient httpClient, DeputyClientSettings settings)
        {
            _httpClient = httpClient;
            _settings = settings;

            _httpClient.BaseAddress = new Uri(_settings.InstanceUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", _settings.Token);

            if (!_settings.IncludeMetadata)
            {
                _httpClient.DefaultRequestHeaders.Add("dp-meta-option", "none");
            }

            _resourcesClient = new(() => new ResourcesClient(_httpClient));
        }
    }

    public class DeputyClientSettings
    {
        public string InstanceUrl { get; set; } = null!;
        public string Token { get; set; } = null!;
        public bool IncludeMetadata { get; set; } = false;
    }
}
