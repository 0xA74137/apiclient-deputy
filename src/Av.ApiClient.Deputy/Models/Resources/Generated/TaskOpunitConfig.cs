﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<TaskOpunitConfig>))]
public class TaskOpunitConfig : IResource, IHasPropertyTracker<TaskOpunitConfigPropertyTracker>
{
    private long? _Id;
    private long? _TaskSetupId;
    private long? _TaskGroupId;
    private bool? _Active;
    private long? _SortOrder;
    private long? _OpUnitId;
    private long? _Schedule;
    private long? _Type;
    private string? _AvailableAfter;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private TaskOpunitConfigPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("TaskSetupId")]
    public long? TaskSetupId { get => _TaskSetupId; set { _TaskSetupId = value; _tracker.TaskSetupId = true; }}
    [JsonPropertyName("TaskGroupId")]
    public long? TaskGroupId { get => _TaskGroupId; set { _TaskGroupId = value; _tracker.TaskGroupId = true; }}
    [JsonPropertyName("Active")]
    public bool? Active { get => _Active; set { _Active = value; _tracker.Active = true; }}
    [JsonPropertyName("SortOrder")]
    public long? SortOrder { get => _SortOrder; set { _SortOrder = value; _tracker.SortOrder = true; }}
    [JsonPropertyName("OpUnitId")]
    public long? OpUnitId { get => _OpUnitId; set { _OpUnitId = value; _tracker.OpUnitId = true; }}
    [JsonPropertyName("Schedule")]
    public long? Schedule { get => _Schedule; set { _Schedule = value; _tracker.Schedule = true; }}
    [JsonPropertyName("Type")]
    public long? Type { get => _Type; set { _Type = value; _tracker.Type = true; }}
    [JsonPropertyName("AvailableAfter")]
    public string? AvailableAfter { get => _AvailableAfter; set { _AvailableAfter = value; _tracker.AvailableAfter = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonConverter(typeof(JoinConverter<TaskSetup>))]
    public Join<TaskSetup>? TaskSetup { get; set; }
    [JsonConverter(typeof(JoinConverter<TaskGroupSetup>))]
    public Join<TaskGroupSetup>? TaskGroup { get; set; }
    [JsonConverter(typeof(JoinConverter<OperationalUnit>))]
    public Join<OperationalUnit>? OpUnit { get; set; }
    [JsonConverter(typeof(JoinConverter<Schedule>))]
    public Join<Schedule>? ScheduleObject { get; set; }
    TaskOpunitConfigPropertyTracker IHasPropertyTracker<TaskOpunitConfigPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<TaskOpunitConfigPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<TaskOpunitConfigPropertyTracker>)this).Tracker.Clear();

}

internal class TaskOpunitConfigPropertyTracker
{
    internal bool Id;
    internal bool TaskSetupId;
    internal bool TaskGroupId;
    internal bool Active;
    internal bool SortOrder;
    internal bool OpUnitId;
    internal bool Schedule;
    internal bool Type;
    internal bool AvailableAfter;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        TaskSetupId = false;
        TaskGroupId = false;
        Active = false;
        SortOrder = false;
        OpUnitId = false;
        Schedule = false;
        Type = false;
        AvailableAfter = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class TaskOpunitConfigSerializer : JsonConverter<TaskOpunitConfig>
{
    public override TaskOpunitConfig? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,TaskOpunitConfig value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<TaskOpunitConfigPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.TaskSetupId)
        {
            writer.WritePropertyName("TaskSetupId");
            JsonSerializer.Serialize(writer,value.TaskSetupId,options);
        }
        if (tracker.TaskGroupId)
        {
            writer.WritePropertyName("TaskGroupId");
            JsonSerializer.Serialize(writer,value.TaskGroupId,options);
        }
        if (tracker.Active)
        {
            writer.WritePropertyName("Active");
            JsonSerializer.Serialize(writer,value.Active,options);
        }
        if (tracker.SortOrder)
        {
            writer.WritePropertyName("SortOrder");
            JsonSerializer.Serialize(writer,value.SortOrder,options);
        }
        if (tracker.OpUnitId)
        {
            writer.WritePropertyName("OpUnitId");
            JsonSerializer.Serialize(writer,value.OpUnitId,options);
        }
        if (tracker.Schedule)
        {
            writer.WritePropertyName("Schedule");
            JsonSerializer.Serialize(writer,value.Schedule,options);
        }
        if (tracker.Type)
        {
            writer.WritePropertyName("Type");
            JsonSerializer.Serialize(writer,value.Type,options);
        }
        if (tracker.AvailableAfter)
        {
            writer.WritePropertyName("AvailableAfter");
            JsonSerializer.Serialize(writer,value.AvailableAfter,options);
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

