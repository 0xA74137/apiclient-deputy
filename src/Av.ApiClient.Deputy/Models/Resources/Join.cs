namespace Av.ApiClients.Deputy.Models.Resources
{
    public class Join<TRes>
        where TRes : IResource, new()
    {
        public TRes Value { get; set; } = new TRes();
    }

    public class Assoc<TRes>
        where TRes : IResource, new()
    {
        public TRes Value { get; set; } = new TRes();
    }
}
