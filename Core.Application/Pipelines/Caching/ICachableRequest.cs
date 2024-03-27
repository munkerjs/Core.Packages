using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; set; }
    bool BypassCache { get; set; }
    TimeSpan? SlidingExpiration { get; }
}
