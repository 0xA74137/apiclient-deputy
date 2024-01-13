using Av.ApiClients.Deputy.Models;
using Av.ApiClients.Deputy.Models.Resources;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Av.ApiClients.Deputy.Tests;

public class QueryBuilderTests
{
    [Fact]
    public void Test1()
    {
        DeputyClient client = null!;
        var employees = new List<long?>() { 1, 2, 3 };
        var query = client.Resources.Timesheets
            .Where(t => t.Date >= new DateTime(2024, 01, 01))
            .Where(t => t.Date < new DateTime(2025, 01, 01))
            .Where(t => employees.Contains(t.Employee))
            .Include(t => t.RosterObject)
            .Include(t => t.LeaveRuleObject)
            .ToQuery();


        using (new AssertionScope())
        {
            query.Max.Should().Be(5);
            query.Start.Should().Be(60);
            query.Searches.Should().HaveCount(3)
                .And.Contain(new Search { Field = "date", Data = new DateTime(2024, 01, 01), Type = Operator.GreaterOrEqual })
                .And.Contain(new Search { Field = "date", Data = new DateTime(2025, 01, 01), Type = Operator.LessThan })
                .And.Contain(new Search { Field = "employee", Data = new[] { 1, 2, 3 }, Type = Operator.InSet });

            query.Joins.Should()
                .HaveCount(2)
                .And.Contain("RosterObject")
                .And.Contain("LeaveRuleObject");

            query.Aggregations.Should()
                .HaveCount(3)
                .And.Contain(KeyValuePair.Create("TotalTime", Aggregation.Sum))
                .And.Contain(KeyValuePair.Create("Employee", Aggregation.Count))
                .And.Contain(KeyValuePair.Create("Employee", Aggregation.CountDisctinct));
        }
    }
}