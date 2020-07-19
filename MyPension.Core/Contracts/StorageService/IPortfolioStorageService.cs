using MyPension.Core.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPension.Core.Contracts.StorageService
{
    public interface IPortfolioStorageService
    {
        Task SavePortfolio(Portfolio portfolio);
        Task UpdatePortfolio(Portfolio portfolio);
        Task<IList<Portfolio>> GetAllPortfolios();
        Task DeletePortfolio(string portfolioId);
    }
}
