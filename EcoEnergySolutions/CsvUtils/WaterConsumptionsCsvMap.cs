using CsvHelper.Configuration;
using EcoEnergySolutions.Models;

namespace EcoEnergySolutions.Utils
{
    public class WaterConsumptionsCsvMap : ClassMap<WaterConsumption>
    {
        public WaterConsumptionsCsvMap()
        {
            Map(m => m.County).Name("Comarca");
            Map(m => m.Population).Name("Població");
            Map(m => m.Year).Name("Any");
            Map(m => m.Consumption).Name("Consum domèstic per càpita");
        }
    }
}
