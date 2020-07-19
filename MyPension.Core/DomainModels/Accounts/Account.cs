using MyPension.Core.DomainModels.Instruments;
using System.Collections.Generic;

namespace MyPension.Core.DomainModels.Accounts
{
    public abstract class Account<T> where T: Instrument
    {
        public string Identifier { get; set; }
        public string Alias { get; set; }
        public IList<T> Holdings { get; }

        public Account()
        {
            Holdings = new List<T>();
        }
    }
}
