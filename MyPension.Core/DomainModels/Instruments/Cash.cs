namespace MyPension.Core.DomainModels.Instruments
{
    public class Cash : Instrument
    {
        public override AssetClass AssetClass => AssetClass.MONEY_MARKET;

        public override string Identifier => Currency;

        public string Currency { get; set; }
    }
}
