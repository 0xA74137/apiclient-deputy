﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<CustomAppData>))]
public class CustomAppData : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("DocumentId")]
    public string? DocumentId { get; set; }
    [JsonPropertyName("Data")]
    public string? Data { get; set; }
    [JsonPropertyName("KeyInt")]
    public long? KeyInt { get; set; }
    [JsonPropertyName("KeyString")]
    public string? KeyString { get; set; }
    [JsonPropertyName("Label")]
    public string? Label { get; set; }
    [JsonPropertyName("OperationalUnit")]
    public long? OperationalUnit { get; set; }
    [JsonPropertyName("Employee")]
    public long? Employee { get; set; }
    [JsonPropertyName("Permission")]
    public string? Permission { get; set; }
    [JsonPropertyName("Deleted")]
    public bool? Deleted { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }
}
