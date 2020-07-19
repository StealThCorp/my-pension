namespace MyPension.Core.DomainModels.Instruments
{
    public class Fund : Instrument
    {
        public override AssetClass AssetClass { get; }
        public override string Identifier => Isin;
        public string Isin { get; set; }
        public string Name { get; set; }
    }
}
