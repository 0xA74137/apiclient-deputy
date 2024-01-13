﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<LeaveAccrual>))]
public class LeaveAccrual : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Employee")]
    public long? Employee { get; set; }
    [JsonPropertyName("EmployeeHistory")]
    public long? EmployeeHistory { get; set; }
    [JsonPropertyName("TransactionDate")]
    public DateTimeOffset? TransactionDate { get; set; }
    [JsonPropertyName("Type")]
    public long? Type { get; set; }
    [JsonPropertyName("LeaveRule")]
    public long? LeaveRule { get; set; }
    [JsonPropertyName("Hours")]
    public double? Hours { get; set; }
    [JsonPropertyName("Days")]
    public double? Days { get; set; }
    [JsonPropertyName("Comment")]
    public string? Comment { get; set; }
    [JsonPropertyName("FkId")]
    public long? FkId { get; set; }
    [JsonPropertyName("BalanceCalculatedAt")]
    public DateTimeOffset? BalanceCalculatedAt { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }


    [JsonConverter(typeof(JoinConverter<Employee>))]
    public Join<Employee>? EmployeeObject { get; set; }

    [JsonConverter(typeof(JoinConverter<LeaveRules>))]
    public Join<LeaveRules>? LeaveRuleObject { get; set; }
}
