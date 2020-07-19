using MyPension.Core.DomainModels.Instruments;
using System.Collections.Generic;

namespace MyPension.Core.DomainModels
{
    public class Portfolio
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IDictionary<AssetClass, IList<Holding>> AssetAllocation { get; }

        public Portfolio()
        {
            AssetAllocation = new Dictionary<AssetClass, IList<Holding>>();
        }
    }
}
