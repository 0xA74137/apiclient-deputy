using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Av.ApiClients.Deputy.Models.Resources
{
    public interface IResource
    {
        long? Id { get; set; }
        DateTimeOffset? Created { get; set; }
        DateTimeOffset? Modified { get; set; }
    }

    public class Resource : IResource
    {
        public long? Id { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }

        protected bool SetField<T>(ref T field, T value, string name)
        {
            if(EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            return true;
        }
    }
}
