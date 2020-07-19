using MyPension.Core.DomainModels;
using System.Threading.Tasks;

namespace MyPension.Core.Contracts.Business
{
    public interface IPortfolioHandler
    {
        Task DeclareHoldings(string portfolioId, Holding holding); 
    }
}
