namespace EcoEnergySolutions.Models
{
    public class WaterConsumption
    {
        public int Year { get; set; }
        public int RegionCode { get; set; }
        public string? RegionName { get; set; }
        public int Population { get; set; }
        public int DomesticNetwork { get; set; }
        public int EconomicSources { get; set; }
        public int TotalConsumption { get; set; }
        public double CapitaConsumption { get; set; }
    }
}
