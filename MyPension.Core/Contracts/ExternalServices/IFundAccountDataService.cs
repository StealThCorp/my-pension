using MyPension.Core.DomainModels.Accounts;
using MyPension.Core.DomainModels.Instruments;
using System.Collections.Generic;

namespace MyPension.Core.Contracts.ExternalServices
{
    public interface IFundAccountDataService
    {
        IList<Account<Fund>> GetFundAccounts();
    }
}
