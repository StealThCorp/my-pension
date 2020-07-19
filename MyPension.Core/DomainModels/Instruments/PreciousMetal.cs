namespace MyPension.Core.DomainModels.Instruments
{
    public class PreciousMetal : Instrument
    {
        public override AssetClass AssetClass => AssetClass.COMMODITY;

        public override string Identifier => null;
    }

}
