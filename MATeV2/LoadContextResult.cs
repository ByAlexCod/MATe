using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public enum LoadContextResult
    {
        Success = 0,
        InvalidPath = 1,
        UnableToReadContext = 2,
        CompanyNameMismatch = 3,
        UnableToOpenFile = 4

    }
}
