using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{

    public interface IContextAccessor : IDisposable
    {
        Context Context { get; }
    }
}
