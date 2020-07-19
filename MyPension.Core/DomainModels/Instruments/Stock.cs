namespace MyPension.Core.DomainModels.Instruments
{
    public class Stock : Instrument
    {
        public override AssetClass AssetClass => AssetClass.EQUITY;
        public override string Identifier => Ticker;
        public string Ticker { get; set; }
        public string Exchange { get; set; }
    }
}
