using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Av.ApiClients.Deputy.Models
{
    public record Query
    {
        [JsonPropertyName("start")]
        public int? Start { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("search")]
        public List<Search>? Searches { get; set; }

        [JsonPropertyName("join")]
        public List<string>? Joins { get; set; }

        [JsonPropertyName("group")]
        public List<string>? GroupBys { get; set; }

        [JsonPropertyName("sort")]
        public Dictionary<string, OrderDirection>? Orders { get; set; }

        [JsonPropertyName("aggr")]
        public Dictionary<string, Aggregation>? Aggregations { get; set; }
    }

    public record Search
    {
        [JsonPropertyName("field")]
        public string Field { get; set; } = null!;

        [JsonPropertyName("data")]
        public object Data { get; set; } = null!;

        [JsonPropertyName("type")]
        public Operator Type { get; set; }
    }

    public enum Operator
    {
        [Description("eq")] Equals,
        [Description("gt")] GreaterThan,
        [Description("ge")] GreaterOrEqual,
        [Description("lt")] LessThan,
        [Description("le")] LessOrEqual,
        [Description("lk")] Like,
        [Description("nk")] NotLike,
        [Description("ne")] NotEqual,
        [Description("in")] InSet,
        [Description("nn")] NotInSet,
        [Description("is")] ZeroOrNull,
        [Description("ns")] NotZeroOrNull,
    }

    public enum OrderDirection
    {
        [Description("asc")]
        Ascending,

        [Description("desc")]
        Descending,
    }

    public enum Aggregation
    {
        [Description("sum")]
        Sum,

        [Description("count")]
        Count,

        [Description("countdistinct")]
        CountDisctinct,
    }
}
