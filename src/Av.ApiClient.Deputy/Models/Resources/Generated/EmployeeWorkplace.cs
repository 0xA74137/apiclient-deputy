﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<EmployeeWorkplace>))]
public class EmployeeWorkplace : IResource, IHasPropertyTracker<EmployeeWorkplacePropertyTracker>
{
    private long? _Id;
    private long? _EmployeeId;
    private long? _Company;
    private long? _SortOrder;
    private long? _Agreement1;
    private long? _Agreement2;
    private long? _Agreement3;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private EmployeeWorkplacePropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("EmployeeId")]
    public long? EmployeeId { get => _EmployeeId; set { _EmployeeId = value; _tracker.EmployeeId = true; }}
    [JsonPropertyName("Company")]
    public long? Company { get => _Company; set { _Company = value; _tracker.Company = true; }}
    [JsonPropertyName("SortOrder")]
    public long? SortOrder { get => _SortOrder; set { _SortOrder = value; _tracker.SortOrder = true; }}
    [JsonPropertyName("Agreement1")]
    public long? Agreement1 { get => _Agreement1; set { _Agreement1 = value; _tracker.Agreement1 = true; }}
    [JsonPropertyName("Agreement2")]
    public long? Agreement2 { get => _Agreement2; set { _Agreement2 = value; _tracker.Agreement2 = true; }}
    [JsonPropertyName("Agreement3")]
    public long? Agreement3 { get => _Agreement3; set { _Agreement3 = value; _tracker.Agreement3 = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonConverter(typeof(JoinConverter<Employee>))]
    public Join<Employee>? Employee { get; set; }
    [JsonConverter(typeof(JoinConverter<Company>))]
    public Join<Company>? CompanyObject { get; set; }
    [JsonConverter(typeof(JoinConverter<EmployeeAgreement>))]
    public Join<EmployeeAgreement>? Agreement1Object { get; set; }
    [JsonConverter(typeof(JoinConverter<EmployeeAgreement>))]
    public Join<EmployeeAgreement>? Agreement2Object { get; set; }
    [JsonConverter(typeof(JoinConverter<EmployeeAgreement>))]
    public Join<EmployeeAgreement>? Agreement3Object { get; set; }
    EmployeeWorkplacePropertyTracker IHasPropertyTracker<EmployeeWorkplacePropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<EmployeeWorkplacePropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<EmployeeWorkplacePropertyTracker>)this).Tracker.Clear();

}

internal class EmployeeWorkplacePropertyTracker
{
    internal bool Id;
    internal bool EmployeeId;
    internal bool Company;
    internal bool SortOrder;
    internal bool Agreement1;
    internal bool Agreement2;
    internal bool Agreement3;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        EmployeeId = false;
        Company = false;
        SortOrder = false;
        Agreement1 = false;
        Agreement2 = false;
        Agreement3 = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class EmployeeWorkplaceSerializer : JsonConverter<EmployeeWorkplace>
{
    public override EmployeeWorkplace? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,EmployeeWorkplace value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<EmployeeWorkplacePropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.EmployeeId)
        {
            writer.WritePropertyName("EmployeeId");
            JsonSerializer.Serialize(writer,value.EmployeeId,options);
        }
        if (tracker.Company)
        {
            writer.WritePropertyName("Company");
            JsonSerializer.Serialize(writer,value.Company,options);
        }
        if (tracker.SortOrder)
        {
            writer.WritePropertyName("SortOrder");
            JsonSerializer.Serialize(writer,value.SortOrder,options);
        }
        if (tracker.Agreement1)
        {
            writer.WritePropertyName("Agreement1");
            JsonSerializer.Serialize(writer,value.Agreement1,options);
        }
        if (tracker.Agreement2)
        {
            writer.WritePropertyName("Agreement2");
            JsonSerializer.Serialize(writer,value.Agreement2,options);
        }
        if (tracker.Agreement3)
        {
            writer.WritePropertyName("Agreement3");
            JsonSerializer.Serialize(writer,value.Agreement3,options);
        }
        if (tracker.Creator)
        {
            writer.WritePropertyName("Creator");
            JsonSerializer.Serialize(writer,value.Creator,options);
        }
        if (tracker.Created)
        {
            writer.WritePropertyName("Created");
            JsonSerializer.Serialize(writer,value.Created,options);
        }
        if (tracker.Modified)
        {
            writer.WritePropertyName("Modified");
            JsonSerializer.Serialize(writer,value.Modified,options);
        }
        writer.WriteEndObject();
    }

}

