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
}
