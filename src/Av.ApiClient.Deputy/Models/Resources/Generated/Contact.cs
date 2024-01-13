﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<Contact>))]
public class Contact : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Phone1")]
    public string? Phone1 { get; set; }
    [JsonPropertyName("Phone2")]
    public string? Phone2 { get; set; }
    [JsonPropertyName("Phone3")]
    public string? Phone3 { get; set; }
    [JsonPropertyName("Fax")]
    public string? Fax { get; set; }
    [JsonPropertyName("Phone1Type")]
    public string? Phone1Type { get; set; }
    [JsonPropertyName("Phone2Type")]
    public string? Phone2Type { get; set; }
    [JsonPropertyName("Phone3Type")]
    public string? Phone3Type { get; set; }
    [JsonPropertyName("PrimaryPhone")]
    public long? PrimaryPhone { get; set; }
    [JsonPropertyName("Email1")]
    public string? Email1 { get; set; }
    [JsonPropertyName("Email1Type")]
    public string? Email1Type { get; set; }
    [JsonPropertyName("Email2Type")]
    public string? Email2Type { get; set; }
    [JsonPropertyName("Email2")]
    public string? Email2 { get; set; }
    [JsonPropertyName("PrimaryEmail")]
    public long? PrimaryEmail { get; set; }
    [JsonPropertyName("Im1")]
    public string? Im1 { get; set; }
    [JsonPropertyName("Im2")]
    public string? Im2 { get; set; }
    [JsonPropertyName("Im1Type")]
    public string? Im1Type { get; set; }
    [JsonPropertyName("Im2Type")]
    public string? Im2Type { get; set; }
    [JsonPropertyName("Web")]
    public string? Web { get; set; }
    [JsonPropertyName("Notes")]
    public string? Notes { get; set; }
    [JsonPropertyName("Saved")]
    public bool? Saved { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }
}
