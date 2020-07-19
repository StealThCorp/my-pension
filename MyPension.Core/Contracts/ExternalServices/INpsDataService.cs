using MyPension.Core.DomainModels;
using System.Collections.Generic;

namespace MyPension.Core.Contracts.ExternalServices
{
    public interface INpsDataService
    {
        IList<Holding> GetNpsHoldings();
    }
}
