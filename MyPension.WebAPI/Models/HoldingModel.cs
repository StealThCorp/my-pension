namespace MyPension.WebAPI.Models
{
    public class HoldingModel
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string AssetClass { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitsAvailable { get; set; }
    }
}
