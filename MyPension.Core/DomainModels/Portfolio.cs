using MyPension.Core.DomainModels.Accounts;
using MyPension.Core.DomainModels.Instruments;
using System.Collections.Generic;

namespace MyPension.Core.DomainModels
{
    public class Portfolio
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IList<Account<Fund>> FundAccounts { get; }
        public IList<Account<Stock>> StockAccounts { get; }
        public IList<Account<Cash>> BankAccounts { get; }

        public Portfolio()
        {
            FundAccounts = new List<Account<Fund>>();
            StockAccounts = new List<Account<Stock>>();
            BankAccounts = new List<Account<Cash>>();
        }
    }
}
