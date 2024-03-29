﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<LeaveAccrual>))]
public class LeaveAccrual : IResource, IHasPropertyTracker<LeaveAccrualPropertyTracker>
{
    private long? _Id;
    private long? _Employee;
    private long? _EmployeeHistory;
    private DateTimeOffset? _TransactionDate;
    private long? _Type;
    private long? _LeaveRule;
    private double? _Hours;
    private double? _Days;
    private string? _Comment;
    private long? _FkId;
    private DateTimeOffset? _BalanceCalculatedAt;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private LeaveAccrualPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("Employee")]
    public long? Employee { get => _Employee; set { _Employee = value; _tracker.Employee = true; }}
    [JsonPropertyName("EmployeeHistory")]
    public long? EmployeeHistory { get => _EmployeeHistory; set { _EmployeeHistory = value; _tracker.EmployeeHistory = true; }}
    [JsonPropertyName("TransactionDate")]
    public DateTimeOffset? TransactionDate { get => _TransactionDate; set { _TransactionDate = value; _tracker.TransactionDate = true; }}
    [JsonPropertyName("Type")]
    public long? Type { get => _Type; set { _Type = value; _tracker.Type = true; }}
    [JsonPropertyName("LeaveRule")]
    public long? LeaveRule { get => _LeaveRule; set { _LeaveRule = value; _tracker.LeaveRule = true; }}
    [JsonPropertyName("Hours")]
    public double? Hours { get => _Hours; set { _Hours = value; _tracker.Hours = true; }}
    [JsonPropertyName("Days")]
    public double? Days { get => _Days; set { _Days = value; _tracker.Days = true; }}
    [JsonPropertyName("Comment")]
    public string? Comment { get => _Comment; set { _Comment = value; _tracker.Comment = true; }}
    [JsonPropertyName("FkId")]
    public long? FkId { get => _FkId; set { _FkId = value; _tracker.FkId = true; }}
    [JsonPropertyName("BalanceCalculatedAt")]
    public DateTimeOffset? BalanceCalculatedAt { get => _BalanceCalculatedAt; set { _BalanceCalculatedAt = value; _tracker.BalanceCalculatedAt = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonConverter(typeof(JoinConverter<Employee>))]
    public Join<Employee>? EmployeeObject { get; set; }
    [JsonConverter(typeof(JoinConverter<LeaveRules>))]
    public Join<LeaveRules>? LeaveRuleObject { get; set; }
    LeaveAccrualPropertyTracker IHasPropertyTracker<LeaveAccrualPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<LeaveAccrualPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<LeaveAccrualPropertyTracker>)this).Tracker.Clear();

}

internal class LeaveAccrualPropertyTracker
{
    internal bool Id;
    internal bool Employee;
    internal bool EmployeeHistory;
    internal bool TransactionDate;
    internal bool Type;
    internal bool LeaveRule;
    internal bool Hours;
    internal bool Days;
    internal bool Comment;
    internal bool FkId;
    internal bool BalanceCalculatedAt;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        Employee = false;
        EmployeeHistory = false;
        TransactionDate = false;
        Type = false;
        LeaveRule = false;
        Hours = false;
        Days = false;
        Comment = false;
        FkId = false;
        BalanceCalculatedAt = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class LeaveAccrualSerializer : JsonConverter<LeaveAccrual>
{
    public override LeaveAccrual? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,LeaveAccrual value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<LeaveAccrualPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.Employee)
        {
            writer.WritePropertyName("Employee");
            JsonSerializer.Serialize(writer,value.Employee,options);
        }
        if (tracker.EmployeeHistory)
        {
            writer.WritePropertyName("EmployeeHistory");
            JsonSerializer.Serialize(writer,value.EmployeeHistory,options);
        }
        if (tracker.TransactionDate)
        {
            writer.WritePropertyName("TransactionDate");
            JsonSerializer.Serialize(writer,value.TransactionDate,options);
        }
        if (tracker.Type)
        {
            writer.WritePropertyName("Type");
            JsonSerializer.Serialize(writer,value.Type,options);
        }
        if (tracker.LeaveRule)
        {
            writer.WritePropertyName("LeaveRule");
            JsonSerializer.Serialize(writer,value.LeaveRule,options);
        }
        if (tracker.Hours)
        {
            writer.WritePropertyName("Hours");
            JsonSerializer.Serialize(writer,value.Hours,options);
        }
        if (tracker.Days)
        {
            writer.WritePropertyName("Days");
            JsonSerializer.Serialize(writer,value.Days,options);
        }
        if (tracker.Comment)
        {
            writer.WritePropertyName("Comment");
            JsonSerializer.Serialize(writer,value.Comment,options);
        }
        if (tracker.FkId)
        {
            writer.WritePropertyName("FkId");
            JsonSerializer.Serialize(writer,value.FkId,options);
        }
        if (tracker.BalanceCalculatedAt)
        {
            writer.WritePropertyName("BalanceCalculatedAt");
            JsonSerializer.Serialize(writer,value.BalanceCalculatedAt,options);
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

