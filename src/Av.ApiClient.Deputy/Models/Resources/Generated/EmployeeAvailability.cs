﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<EmployeeAvailability>))]
public class EmployeeAvailability : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Employee")]
    public long? Employee { get; set; }
    [JsonPropertyName("Type")]
    public long? Type { get; set; }
    [JsonPropertyName("MaxDateRecurringGenerated")]
    public DateTimeOffset? MaxDateRecurringGenerated { get; set; }
    [JsonPropertyName("StartTime")]
    public long? StartTime { get; set; }
    [JsonPropertyName("EndTime")]
    public long? EndTime { get; set; }
    [JsonPropertyName("Date")]
    public DateTimeOffset? Date { get; set; }
    [JsonPropertyName("Comment")]
    public string? Comment { get; set; }
    [JsonPropertyName("Schedule")]
    public long? Schedule { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }


    [JsonConverter(typeof(JoinConverter<Employee>))]
    public Join<Employee>? EmployeeObject { get; set; }

    [JsonConverter(typeof(JoinConverter<Schedule>))]
    public Join<Schedule>? ScheduleObject { get; set; }
}
