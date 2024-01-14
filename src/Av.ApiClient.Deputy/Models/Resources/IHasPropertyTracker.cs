using System.Runtime.CompilerServices;

namespace Av.ApiClients.Deputy.Models.Resources
{
    public interface IHasPropertyTracker<TTracker>
        where TTracker : class
    {
        public TTracker Tracker { get; }
        public void ClearTrackedProperties();
    }
}
