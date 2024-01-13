﻿// <auto-generated/>
#nullable enable
using System.Text.Json.Serialization;
using Av.ApiClients.Deputy.Converters;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Models.Resources;

[JsonConverter(typeof(ResourceConverter<Employee>))]
public class Employee : IResource
{
    [JsonPropertyName("Id")]
    public long? Id { get; set; }
    [JsonPropertyName("Company")]
    public long? Company { get; set; }
    [JsonPropertyName("FirstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("LastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("DisplayName")]
    public string? DisplayName { get; set; }
    [JsonPropertyName("OtherName")]
    public string? OtherName { get; set; }
    [JsonPropertyName("Salutation")]
    public string? Salutation { get; set; }
    [JsonPropertyName("MainAddress")]
    public long? MainAddress { get; set; }
    [JsonPropertyName("PostalAddress")]
    public long? PostalAddress { get; set; }
    [JsonPropertyName("Contact")]
    public long? Contact { get; set; }
    [JsonPropertyName("EmergencyAddress")]
    public long? EmergencyAddress { get; set; }
    [JsonPropertyName("DateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; set; }
    [JsonPropertyName("Gender")]
    public long? Gender { get; set; }
    [JsonPropertyName("Pronouns")]
    public long? Pronouns { get; set; }
    [JsonPropertyName("CustomPronouns")]
    public string? CustomPronouns { get; set; }
    [JsonPropertyName("Photo")]
    public long? Photo { get; set; }
    [JsonPropertyName("UserId")]
    public long? UserId { get; set; }
    [JsonPropertyName("JobAppId")]
    public long? JobAppId { get; set; }
    [JsonPropertyName("Active")]
    public bool? Active { get; set; }
    [JsonPropertyName("StartDate")]
    public DateTimeOffset? StartDate { get; set; }
    [JsonPropertyName("TerminationDate")]
    public DateTimeOffset? TerminationDate { get; set; }
    [JsonPropertyName("StressProfile")]
    public long? StressProfile { get; set; }
    [JsonPropertyName("Position")]
    public string? Position { get; set; }
    [JsonPropertyName("HigherDuty")]
    public bool? HigherDuty { get; set; }
    [JsonPropertyName("Role")]
    public long? Role { get; set; }
    [JsonPropertyName("AllowAppraisal")]
    public bool? AllowAppraisal { get; set; }
    [JsonPropertyName("HistoryId")]
    public long? HistoryId { get; set; }
    [JsonPropertyName("CustomFieldData")]
    public long? CustomFieldData { get; set; }
    [JsonPropertyName("OnboardingId")]
    public string? OnboardingId { get; set; }
    [JsonPropertyName("Creator")]
    public long? Creator { get; set; }
    [JsonPropertyName("Created")]
    public DateTimeOffset? Created { get; set; }
    [JsonPropertyName("Modified")]
    public DateTimeOffset? Modified { get; set; }


    [JsonConverter(typeof(JoinConverter<Company>))]
    public Join<Company>? CompanyObject { get; set; }

    [JsonConverter(typeof(JoinConverter<Address>))]
    public Join<Address>? MainAddressObject { get; set; }

    [JsonConverter(typeof(JoinConverter<Address>))]
    public Join<Address>? PostalAddressObject { get; set; }

    [JsonConverter(typeof(JoinConverter<Contact>))]
    public Join<Contact>? ContactObject { get; set; }

    [JsonConverter(typeof(JoinConverter<Address>))]
    public Join<Address>? EmergencyAddressObject { get; set; }

    [JsonConverter(typeof(JoinConverter<StressProfile>))]
    public Join<StressProfile>? StressProfileObject { get; set; }

    [JsonConverter(typeof(JoinConverter<EmployeeRole>))]
    public Join<EmployeeRole>? RoleObject { get; set; }

    [JsonConverter(typeof(JoinConverter<CustomFieldData>))]
    public Join<CustomFieldData>? CustomFieldDataObject { get; set; }
}
