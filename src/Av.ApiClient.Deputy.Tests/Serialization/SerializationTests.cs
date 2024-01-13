using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Models.Resources;
using FluentAssertions;

namespace Av.ApiClients.Deputy.Tests.Serialization
{
    public class SerializationTests
    {
        [Fact]
        public void Test_null_values_dont_get_serialized()
        {
            var timesheet = new Timesheet
            {
                Id = 1,
            };

            var serialized = JsonSerializer.Serialize(timesheet, DeputyClient.SerializerOptions);

            serialized.Should().BeEquivalentTo(@"{""Id"":1}");
        }

        [Fact]
        public void Test_joins_dont_get_serialized()
        {
            var timesheet = new Timesheet
            {
                Id = 1,
                EmployeeObject = new Join<Employee>()
                {
                    Value = new()
                    {
                        Id = 2
                    }
                }
            };

            var serialized = JsonSerializer.Serialize(timesheet, DeputyClient.SerializerOptions);
            serialized.Should().BeEquivalentTo(@"{""Id"":1}");
        }
    }
}
