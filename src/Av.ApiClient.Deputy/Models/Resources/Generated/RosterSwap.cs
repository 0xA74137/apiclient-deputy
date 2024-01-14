﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<RosterSwap>))]
public class RosterSwap : IResource, IHasPropertyTracker<RosterSwapPropertyTracker>
{
    private long? _Id;
    private long? _SourceRoster;
    private long? _TargetRoster;
    private long? _Employee;
    private long? _Status;
    private string? _RequestMessage;
    private string? _ResponseMessage;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private RosterSwapPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("SourceRoster")]
    public long? SourceRoster { get => _SourceRoster; set { _SourceRoster = value; _tracker.SourceRoster = true; }}
    [JsonPropertyName("TargetRoster")]
    public long? TargetRoster { get => _TargetRoster; set { _TargetRoster = value; _tracker.TargetRoster = true; }}
    [JsonPropertyName("Employee")]
    public long? Employee { get => _Employee; set { _Employee = value; _tracker.Employee = true; }}
    [JsonPropertyName("Status")]
    public long? Status { get => _Status; set { _Status = value; _tracker.Status = true; }}
    [JsonPropertyName("RequestMessage")]
    public string? RequestMessage { get => _RequestMessage; set { _RequestMessage = value; _tracker.RequestMessage = true; }}
    [JsonPropertyName("ResponseMessage")]
    public string? ResponseMessage { get => _ResponseMessage; set { _ResponseMessage = value; _tracker.ResponseMessage = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonConverter(typeof(JoinConverter<Roster>))]
    public Join<Roster>? SourceRosterObject { get; set; }
    [JsonConverter(typeof(JoinConverter<Roster>))]
    public Join<Roster>? TargetRosterObject { get; set; }
    [JsonConverter(typeof(JoinConverter<Employee>))]
    public Join<Employee>? EmployeeObject { get; set; }
    RosterSwapPropertyTracker IHasPropertyTracker<RosterSwapPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<RosterSwapPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<RosterSwapPropertyTracker>)this).Tracker.Clear();

}

internal class RosterSwapPropertyTracker
{
    internal bool Id;
    internal bool SourceRoster;
    internal bool TargetRoster;
    internal bool Employee;
    internal bool Status;
    internal bool RequestMessage;
    internal bool ResponseMessage;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        SourceRoster = false;
        TargetRoster = false;
        Employee = false;
        Status = false;
        RequestMessage = false;
        ResponseMessage = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class RosterSwapSerializer : JsonConverter<RosterSwap>
{
    public override RosterSwap? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,RosterSwap value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<RosterSwapPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.SourceRoster)
        {
            writer.WritePropertyName("SourceRoster");
            JsonSerializer.Serialize(writer,value.SourceRoster,options);
        }
        if (tracker.TargetRoster)
        {
            writer.WritePropertyName("TargetRoster");
            JsonSerializer.Serialize(writer,value.TargetRoster,options);
        }
        if (tracker.Employee)
        {
            writer.WritePropertyName("Employee");
            JsonSerializer.Serialize(writer,value.Employee,options);
        }
        if (tracker.Status)
        {
            writer.WritePropertyName("Status");
            JsonSerializer.Serialize(writer,value.Status,options);
        }
        if (tracker.RequestMessage)
        {
            writer.WritePropertyName("RequestMessage");
            JsonSerializer.Serialize(writer,value.RequestMessage,options);
        }
        if (tracker.ResponseMessage)
        {
            writer.WritePropertyName("ResponseMessage");
            JsonSerializer.Serialize(writer,value.ResponseMessage,options);
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

