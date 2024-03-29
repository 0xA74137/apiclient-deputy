﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<LeaveRules>))]
public class LeaveRules : IResource, IHasPropertyTracker<LeaveRulesPropertyTracker>
{
    private long? _Id;
    private string? _SvcLeavePolicyId;
    private string? _Name;
    private string? _Type;
    private string? _Description;
    private double? _MaxAllowedAnnually;
    private bool? _PaidLeave;
    private bool? _AnnualRollOver;
    private bool? _Visible;
    private long? _UnitType;
    private long? _ResetType;
    private long? _ResetSchedule;
    private double? _ResetValue;
    private bool? _PayoutOnTermination;
    private long? _EntitlementAfterMonth;
    private long? _ExportType;
    private string? _PayrollCategory;
    private long? _CalcType;
    private string? _Calc;
    private string? _F00;
    private string? _F01;
    private string? _F02;
    private string? _F03;
    private string? _F04;
    private string? _F05;
    private string? _F06;
    private string? _F07;
    private string? _F08;
    private string? _F09;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private LeaveRulesPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("SvcLeavePolicyId")]
    public string? SvcLeavePolicyId { get => _SvcLeavePolicyId; set { _SvcLeavePolicyId = value; _tracker.SvcLeavePolicyId = true; }}
    [JsonPropertyName("Name")]
    public string? Name { get => _Name; set { _Name = value; _tracker.Name = true; }}
    [JsonPropertyName("Type")]
    public string? Type { get => _Type; set { _Type = value; _tracker.Type = true; }}
    [JsonPropertyName("Description")]
    public string? Description { get => _Description; set { _Description = value; _tracker.Description = true; }}
    [JsonPropertyName("MaxAllowedAnnually")]
    public double? MaxAllowedAnnually { get => _MaxAllowedAnnually; set { _MaxAllowedAnnually = value; _tracker.MaxAllowedAnnually = true; }}
    [JsonPropertyName("PaidLeave")]
    public bool? PaidLeave { get => _PaidLeave; set { _PaidLeave = value; _tracker.PaidLeave = true; }}
    [JsonPropertyName("AnnualRollOver")]
    public bool? AnnualRollOver { get => _AnnualRollOver; set { _AnnualRollOver = value; _tracker.AnnualRollOver = true; }}
    [JsonPropertyName("Visible")]
    public bool? Visible { get => _Visible; set { _Visible = value; _tracker.Visible = true; }}
    [JsonPropertyName("UnitType")]
    public long? UnitType { get => _UnitType; set { _UnitType = value; _tracker.UnitType = true; }}
    [JsonPropertyName("ResetType")]
    public long? ResetType { get => _ResetType; set { _ResetType = value; _tracker.ResetType = true; }}
    [JsonPropertyName("ResetSchedule")]
    public long? ResetSchedule { get => _ResetSchedule; set { _ResetSchedule = value; _tracker.ResetSchedule = true; }}
    [JsonPropertyName("ResetValue")]
    public double? ResetValue { get => _ResetValue; set { _ResetValue = value; _tracker.ResetValue = true; }}
    [JsonPropertyName("PayoutOnTermination")]
    public bool? PayoutOnTermination { get => _PayoutOnTermination; set { _PayoutOnTermination = value; _tracker.PayoutOnTermination = true; }}
    [JsonPropertyName("EntitlementAfterMonth")]
    public long? EntitlementAfterMonth { get => _EntitlementAfterMonth; set { _EntitlementAfterMonth = value; _tracker.EntitlementAfterMonth = true; }}
    [JsonPropertyName("ExportType")]
    public long? ExportType { get => _ExportType; set { _ExportType = value; _tracker.ExportType = true; }}
    [JsonPropertyName("PayrollCategory")]
    public string? PayrollCategory { get => _PayrollCategory; set { _PayrollCategory = value; _tracker.PayrollCategory = true; }}
    [JsonPropertyName("CalcType")]
    public long? CalcType { get => _CalcType; set { _CalcType = value; _tracker.CalcType = true; }}
    [JsonPropertyName("Calc")]
    public string? Calc { get => _Calc; set { _Calc = value; _tracker.Calc = true; }}
    [JsonPropertyName("F00")]
    public string? F00 { get => _F00; set { _F00 = value; _tracker.F00 = true; }}
    [JsonPropertyName("F01")]
    public string? F01 { get => _F01; set { _F01 = value; _tracker.F01 = true; }}
    [JsonPropertyName("F02")]
    public string? F02 { get => _F02; set { _F02 = value; _tracker.F02 = true; }}
    [JsonPropertyName("F03")]
    public string? F03 { get => _F03; set { _F03 = value; _tracker.F03 = true; }}
    [JsonPropertyName("F04")]
    public string? F04 { get => _F04; set { _F04 = value; _tracker.F04 = true; }}
    [JsonPropertyName("F05")]
    public string? F05 { get => _F05; set { _F05 = value; _tracker.F05 = true; }}
    [JsonPropertyName("F06")]
    public string? F06 { get => _F06; set { _F06 = value; _tracker.F06 = true; }}
    [JsonPropertyName("F07")]
    public string? F07 { get => _F07; set { _F07 = value; _tracker.F07 = true; }}
    [JsonPropertyName("F08")]
    public string? F08 { get => _F08; set { _F08 = value; _tracker.F08 = true; }}
    [JsonPropertyName("F09")]
    public string? F09 { get => _F09; set { _F09 = value; _tracker.F09 = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    [JsonConverter(typeof(JoinConverter<Schedule>))]
    public Join<Schedule>? ResetScheduleObject { get; set; }
    LeaveRulesPropertyTracker IHasPropertyTracker<LeaveRulesPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<LeaveRulesPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<LeaveRulesPropertyTracker>)this).Tracker.Clear();

}

internal class LeaveRulesPropertyTracker
{
    internal bool Id;
    internal bool SvcLeavePolicyId;
    internal bool Name;
    internal bool Type;
    internal bool Description;
    internal bool MaxAllowedAnnually;
    internal bool PaidLeave;
    internal bool AnnualRollOver;
    internal bool Visible;
    internal bool UnitType;
    internal bool ResetType;
    internal bool ResetSchedule;
    internal bool ResetValue;
    internal bool PayoutOnTermination;
    internal bool EntitlementAfterMonth;
    internal bool ExportType;
    internal bool PayrollCategory;
    internal bool CalcType;
    internal bool Calc;
    internal bool F00;
    internal bool F01;
    internal bool F02;
    internal bool F03;
    internal bool F04;
    internal bool F05;
    internal bool F06;
    internal bool F07;
    internal bool F08;
    internal bool F09;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        SvcLeavePolicyId = false;
        Name = false;
        Type = false;
        Description = false;
        MaxAllowedAnnually = false;
        PaidLeave = false;
        AnnualRollOver = false;
        Visible = false;
        UnitType = false;
        ResetType = false;
        ResetSchedule = false;
        ResetValue = false;
        PayoutOnTermination = false;
        EntitlementAfterMonth = false;
        ExportType = false;
        PayrollCategory = false;
        CalcType = false;
        Calc = false;
        F00 = false;
        F01 = false;
        F02 = false;
        F03 = false;
        F04 = false;
        F05 = false;
        F06 = false;
        F07 = false;
        F08 = false;
        F09 = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class LeaveRulesSerializer : JsonConverter<LeaveRules>
{
    public override LeaveRules? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,LeaveRules value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<LeaveRulesPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.SvcLeavePolicyId)
        {
            writer.WritePropertyName("SvcLeavePolicyId");
            JsonSerializer.Serialize(writer,value.SvcLeavePolicyId,options);
        }
        if (tracker.Name)
        {
            writer.WritePropertyName("Name");
            JsonSerializer.Serialize(writer,value.Name,options);
        }
        if (tracker.Type)
        {
            writer.WritePropertyName("Type");
            JsonSerializer.Serialize(writer,value.Type,options);
        }
        if (tracker.Description)
        {
            writer.WritePropertyName("Description");
            JsonSerializer.Serialize(writer,value.Description,options);
        }
        if (tracker.MaxAllowedAnnually)
        {
            writer.WritePropertyName("MaxAllowedAnnually");
            JsonSerializer.Serialize(writer,value.MaxAllowedAnnually,options);
        }
        if (tracker.PaidLeave)
        {
            writer.WritePropertyName("PaidLeave");
            JsonSerializer.Serialize(writer,value.PaidLeave,options);
        }
        if (tracker.AnnualRollOver)
        {
            writer.WritePropertyName("AnnualRollOver");
            JsonSerializer.Serialize(writer,value.AnnualRollOver,options);
        }
        if (tracker.Visible)
        {
            writer.WritePropertyName("Visible");
            JsonSerializer.Serialize(writer,value.Visible,options);
        }
        if (tracker.UnitType)
        {
            writer.WritePropertyName("UnitType");
            JsonSerializer.Serialize(writer,value.UnitType,options);
        }
        if (tracker.ResetType)
        {
            writer.WritePropertyName("ResetType");
            JsonSerializer.Serialize(writer,value.ResetType,options);
        }
        if (tracker.ResetSchedule)
        {
            writer.WritePropertyName("ResetSchedule");
            JsonSerializer.Serialize(writer,value.ResetSchedule,options);
        }
        if (tracker.ResetValue)
        {
            writer.WritePropertyName("ResetValue");
            JsonSerializer.Serialize(writer,value.ResetValue,options);
        }
        if (tracker.PayoutOnTermination)
        {
            writer.WritePropertyName("PayoutOnTermination");
            JsonSerializer.Serialize(writer,value.PayoutOnTermination,options);
        }
        if (tracker.EntitlementAfterMonth)
        {
            writer.WritePropertyName("EntitlementAfterMonth");
            JsonSerializer.Serialize(writer,value.EntitlementAfterMonth,options);
        }
        if (tracker.ExportType)
        {
            writer.WritePropertyName("ExportType");
            JsonSerializer.Serialize(writer,value.ExportType,options);
        }
        if (tracker.PayrollCategory)
        {
            writer.WritePropertyName("PayrollCategory");
            JsonSerializer.Serialize(writer,value.PayrollCategory,options);
        }
        if (tracker.CalcType)
        {
            writer.WritePropertyName("CalcType");
            JsonSerializer.Serialize(writer,value.CalcType,options);
        }
        if (tracker.Calc)
        {
            writer.WritePropertyName("Calc");
            JsonSerializer.Serialize(writer,value.Calc,options);
        }
        if (tracker.F00)
        {
            writer.WritePropertyName("F00");
            JsonSerializer.Serialize(writer,value.F00,options);
        }
        if (tracker.F01)
        {
            writer.WritePropertyName("F01");
            JsonSerializer.Serialize(writer,value.F01,options);
        }
        if (tracker.F02)
        {
            writer.WritePropertyName("F02");
            JsonSerializer.Serialize(writer,value.F02,options);
        }
        if (tracker.F03)
        {
            writer.WritePropertyName("F03");
            JsonSerializer.Serialize(writer,value.F03,options);
        }
        if (tracker.F04)
        {
            writer.WritePropertyName("F04");
            JsonSerializer.Serialize(writer,value.F04,options);
        }
        if (tracker.F05)
        {
            writer.WritePropertyName("F05");
            JsonSerializer.Serialize(writer,value.F05,options);
        }
        if (tracker.F06)
        {
            writer.WritePropertyName("F06");
            JsonSerializer.Serialize(writer,value.F06,options);
        }
        if (tracker.F07)
        {
            writer.WritePropertyName("F07");
            JsonSerializer.Serialize(writer,value.F07,options);
        }
        if (tracker.F08)
        {
            writer.WritePropertyName("F08");
            JsonSerializer.Serialize(writer,value.F08,options);
        }
        if (tracker.F09)
        {
            writer.WritePropertyName("F09");
            JsonSerializer.Serialize(writer,value.F09,options);
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

