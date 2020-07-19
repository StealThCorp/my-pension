using MyPension.Core.DomainModels.Instruments;
using System;

namespace MyPension.Core.DomainModels
{
    public class Holding
    {
        public string Id { get; set; }
        public Instrument Instrument { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal AvailableUnits { get; set; }
        public DateTime UnitPriceDate { get; set; }
        public decimal TotalValuationAmount => UnitPrice * AvailableUnits;
    }
}
