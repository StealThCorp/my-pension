namespace MyPension.Core.DomainModels.Instruments
{
    public abstract class Instrument
    {
        public abstract AssetClass AssetClass { get; }
        public abstract string Identifier { get; }
        public string Name { get; set; }
        public decimal UnitsAvailable { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ValuationAmount => UnitsAvailable * UnitPrice;
    }
}
