﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<EmploymentCondition>))]
public class EmploymentCondition : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
    [JsonPropertyName("Description")]
    public string? Description { get; set; }
    [JsonPropertyName("AwardLevel")]
    public string? AwardLevel { get; set; }
    [JsonPropertyName("EmploymentBasis")]
    public long? EmploymentBasis { get; set; }
    [JsonPropertyName("EmploymentCategory")]
    public long? EmploymentCategory { get; set; }
    [JsonPropertyName("EmploymentPeriod")]
    public long? EmploymentPeriod { get; set; }
    [JsonPropertyName("EmploymentStatus")]
    public long? EmploymentStatus { get; set; }
    [JsonPropertyName("ProbationaryPeriod")]
    public long? ProbationaryPeriod { get; set; }
    [JsonPropertyName("WorkingDaysPerPeriod")]
    public double? WorkingDaysPerPeriod { get; set; }
    [JsonPropertyName("UsualStartTime")]
    public DateTimeOffset? UsualStartTime { get; set; }
    [JsonPropertyName("UsualFinishTime")]
    public DateTimeOffset? UsualFinishTime { get; set; }
    [JsonPropertyName("UsualMealbreak")]
    public DateTimeOffset? UsualMealbreak { get; set; }
    [JsonPropertyName("AvgHoursPerDay")]
    public double? AvgHoursPerDay { get; set; }
    [JsonPropertyName("MinHoursPerDay")]
    public double? MinHoursPerDay { get; set; }
    [JsonPropertyName("MinHoursForLeave")]
    public double? MinHoursForLeave { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }
}
