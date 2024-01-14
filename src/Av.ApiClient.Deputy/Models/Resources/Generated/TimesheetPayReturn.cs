﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<TimesheetPayReturn>))]
public class TimesheetPayReturn : IResource, IHasPropertyTracker<TimesheetPayReturnPropertyTracker>
{
    private long? _Id;
    private long? _Timesheet;
    private long? _PayRule;
    private bool? _Overridden;
    private double? _Value;
    private double? _Cost;
    private string? _OverrideComment;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private string? _EventIds;
    private TimesheetPayReturnPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("Timesheet")]
    public long? Timesheet { get => _Timesheet; set { _Timesheet = value; _tracker.Timesheet = true; }}
    [JsonPropertyName("PayRule")]
    public long? PayRule { get => _PayRule; set { _PayRule = value; _tracker.PayRule = true; }}
    [JsonPropertyName("Overridden")]
    public bool? Overridden { get => _Overridden; set { _Overridden = value; _tracker.Overridden = true; }}
    [JsonPropertyName("Value")]
    public double? Value { get => _Value; set { _Value = value; _tracker.Value = true; }}
    [JsonPropertyName("Cost")]
    public double? Cost { get => _Cost; set { _Cost = value; _tracker.Cost = true; }}
    [JsonPropertyName("OverrideComment")]
    public string? OverrideComment { get => _OverrideComment; set { _OverrideComment = value; _tracker.OverrideComment = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonPropertyName("EventIds")]
    public string? EventIds { get => _EventIds; set { _EventIds = value; _tracker.EventIds = true; }}
    [JsonConverter(typeof(JoinConverter<Timesheet>))]
    public Join<Timesheet>? TimesheetObject { get; set; }
    [JsonConverter(typeof(JoinConverter<PayRules>))]
    public Join<PayRules>? PayRuleObject { get; set; }
    TimesheetPayReturnPropertyTracker IHasPropertyTracker<TimesheetPayReturnPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<TimesheetPayReturnPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<TimesheetPayReturnPropertyTracker>)this).Tracker.Clear();

}

internal class TimesheetPayReturnPropertyTracker
{
    internal bool Id;
    internal bool Timesheet;
    internal bool PayRule;
    internal bool Overridden;
    internal bool Value;
    internal bool Cost;
    internal bool OverrideComment;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;
    internal bool EventIds;

    internal void Clear()
    {
        Id = false;
        Timesheet = false;
        PayRule = false;
        Overridden = false;
        Value = false;
        Cost = false;
        OverrideComment = false;
        Creator = false;
        Created = false;
        Modified = false;
        EventIds = false;
    }

}

internal class TimesheetPayReturnSerializer : JsonConverter<TimesheetPayReturn>
{
    public override TimesheetPayReturn? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,TimesheetPayReturn value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<TimesheetPayReturnPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.Timesheet)
        {
            writer.WritePropertyName("Timesheet");
            JsonSerializer.Serialize(writer,value.Timesheet,options);
        }
        if (tracker.PayRule)
        {
            writer.WritePropertyName("PayRule");
            JsonSerializer.Serialize(writer,value.PayRule,options);
        }
        if (tracker.Overridden)
        {
            writer.WritePropertyName("Overridden");
            JsonSerializer.Serialize(writer,value.Overridden,options);
        }
        if (tracker.Value)
        {
            writer.WritePropertyName("Value");
            JsonSerializer.Serialize(writer,value.Value,options);
        }
        if (tracker.Cost)
        {
            writer.WritePropertyName("Cost");
            JsonSerializer.Serialize(writer,value.Cost,options);
        }
        if (tracker.OverrideComment)
        {
            writer.WritePropertyName("OverrideComment");
            JsonSerializer.Serialize(writer,value.OverrideComment,options);
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
        if (tracker.EventIds)
        {
            writer.WritePropertyName("EventIds");
            JsonSerializer.Serialize(writer,value.EventIds,options);
        }
        writer.WriteEndObject();
    }

}

