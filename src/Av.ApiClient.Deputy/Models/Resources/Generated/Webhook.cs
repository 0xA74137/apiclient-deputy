﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<Webhook>))]
public class Webhook : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Topic")]
    public string? Topic { get; set; }
    [JsonPropertyName("Filters")]
    public string? Filters { get; set; }
    [JsonPropertyName("Address")]
    public string? Address { get; set; }
    [JsonPropertyName("Type")]
    public string? Type { get; set; }
    [JsonPropertyName("Headers")]
    public string? Headers { get; set; }
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }
}
