﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

using System.Text.Json;
[JsonConverter(typeof(ResourceConverter<EmployeeAgreementHistory>))]
public class EmployeeAgreementHistory : IResource, IHasPropertyTracker<EmployeeAgreementHistoryPropertyTracker>
{
    private long? _Id;
    private long? _AgreementId;
    private long? _PayPoint;
    private long? _EmpType;
    private string? _CompanyName;
    private bool? _Active;
    private DateTimeOffset? _StartDate;
    private long? _Contract;
    private long? _SalaryPayRule;
    private long? _ContractFile;
    private string? _PayrollId;
    private long? _PayPeriod;
    private long? _Creator;
    private DateTimeOffset? _Created;
    private DateTimeOffset? _Modified;
    private EmployeeAgreementHistoryPropertyTracker _tracker = new();

    [JsonPropertyName("Id")]
    public long? Id { get => _Id; set { _Id = value; _tracker.Id = true; }}
    [JsonPropertyName("AgreementId")]
    public long? AgreementId { get => _AgreementId; set { _AgreementId = value; _tracker.AgreementId = true; }}
    [JsonPropertyName("PayPoint")]
    public long? PayPoint { get => _PayPoint; set { _PayPoint = value; _tracker.PayPoint = true; }}
    [JsonPropertyName("EmpType")]
    public long? EmpType { get => _EmpType; set { _EmpType = value; _tracker.EmpType = true; }}
    [JsonPropertyName("CompanyName")]
    public string? CompanyName { get => _CompanyName; set { _CompanyName = value; _tracker.CompanyName = true; }}
    [JsonPropertyName("Active")]
    public bool? Active { get => _Active; set { _Active = value; _tracker.Active = true; }}
    [JsonPropertyName("StartDate")]
    public DateTimeOffset? StartDate { get => _StartDate; set { _StartDate = value; _tracker.StartDate = true; }}
    [JsonPropertyName("Contract")]
    public long? Contract { get => _Contract; set { _Contract = value; _tracker.Contract = true; }}
    [JsonPropertyName("SalaryPayRule")]
    public long? SalaryPayRule { get => _SalaryPayRule; set { _SalaryPayRule = value; _tracker.SalaryPayRule = true; }}
    [JsonPropertyName("ContractFile")]
    public long? ContractFile { get => _ContractFile; set { _ContractFile = value; _tracker.ContractFile = true; }}
    [JsonPropertyName("PayrollId")]
    public string? PayrollId { get => _PayrollId; set { _PayrollId = value; _tracker.PayrollId = true; }}
    [JsonPropertyName("PayPeriod")]
    public long? PayPeriod { get => _PayPeriod; set { _PayPeriod = value; _tracker.PayPeriod = true; }}
    [JsonPropertyName("Creator")]
    public long? Creator { get => _Creator; set { _Creator = value; _tracker.Creator = true; }}
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get => _Created; set { _Created = value; _tracker.Created = true; }}
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get => _Modified; set { _Modified = value; _tracker.Modified = true; }}
    EmployeeAgreementHistoryPropertyTracker IHasPropertyTracker<EmployeeAgreementHistoryPropertyTracker>.Tracker => _tracker;

    void IHasPropertyTracker<EmployeeAgreementHistoryPropertyTracker>.ClearTrackedProperties() => ((IHasPropertyTracker<EmployeeAgreementHistoryPropertyTracker>)this).Tracker.Clear();

}

internal class EmployeeAgreementHistoryPropertyTracker
{
    internal bool Id;
    internal bool AgreementId;
    internal bool PayPoint;
    internal bool EmpType;
    internal bool CompanyName;
    internal bool Active;
    internal bool StartDate;
    internal bool Contract;
    internal bool SalaryPayRule;
    internal bool ContractFile;
    internal bool PayrollId;
    internal bool PayPeriod;
    internal bool Creator;
    internal bool Created;
    internal bool Modified;

    internal void Clear()
    {
        Id = false;
        AgreementId = false;
        PayPoint = false;
        EmpType = false;
        CompanyName = false;
        Active = false;
        StartDate = false;
        Contract = false;
        SalaryPayRule = false;
        ContractFile = false;
        PayrollId = false;
        PayPeriod = false;
        Creator = false;
        Created = false;
        Modified = false;
    }

}

internal class EmployeeAgreementHistorySerializer : JsonConverter<EmployeeAgreementHistory>
{
    public override EmployeeAgreementHistory? Read(ref Utf8JsonReader reader,Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer,EmployeeAgreementHistory value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var tracker = ((IHasPropertyTracker<EmployeeAgreementHistoryPropertyTracker>)value).Tracker;
        if (tracker.Id)
        {
            writer.WritePropertyName("Id");
            JsonSerializer.Serialize(writer,value.Id,options);
        }
        if (tracker.AgreementId)
        {
            writer.WritePropertyName("AgreementId");
            JsonSerializer.Serialize(writer,value.AgreementId,options);
        }
        if (tracker.PayPoint)
        {
            writer.WritePropertyName("PayPoint");
            JsonSerializer.Serialize(writer,value.PayPoint,options);
        }
        if (tracker.EmpType)
        {
            writer.WritePropertyName("EmpType");
            JsonSerializer.Serialize(writer,value.EmpType,options);
        }
        if (tracker.CompanyName)
        {
            writer.WritePropertyName("CompanyName");
            JsonSerializer.Serialize(writer,value.CompanyName,options);
        }
        if (tracker.Active)
        {
            writer.WritePropertyName("Active");
            JsonSerializer.Serialize(writer,value.Active,options);
        }
        if (tracker.StartDate)
        {
            writer.WritePropertyName("StartDate");
            JsonSerializer.Serialize(writer,value.StartDate,options);
        }
        if (tracker.Contract)
        {
            writer.WritePropertyName("Contract");
            JsonSerializer.Serialize(writer,value.Contract,options);
        }
        if (tracker.SalaryPayRule)
        {
            writer.WritePropertyName("SalaryPayRule");
            JsonSerializer.Serialize(writer,value.SalaryPayRule,options);
        }
        if (tracker.ContractFile)
        {
            writer.WritePropertyName("ContractFile");
            JsonSerializer.Serialize(writer,value.ContractFile,options);
        }
        if (tracker.PayrollId)
        {
            writer.WritePropertyName("PayrollId");
            JsonSerializer.Serialize(writer,value.PayrollId,options);
        }
        if (tracker.PayPeriod)
        {
            writer.WritePropertyName("PayPeriod");
            JsonSerializer.Serialize(writer,value.PayPeriod,options);
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

