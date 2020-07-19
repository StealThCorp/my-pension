using MyPension.Core.DomainModels.Instruments;
using System.Collections.Generic;

namespace MyPension.Core.Contracts.ExternalServices
{
    public interface IFundDataService
    {
        IList<Fund> GetAvailableFunds();
    }
}
