using CsvHelper.Configuration;
using EcoEnergySolutions.Models;

namespace EcoEnergySolutions.Utils
{
    public class EnergyIndicatorsCsvMap : ClassMap<EnergyIndicator>
    {
        public EnergyIndicatorsCsvMap()
        {
            Map(m => m.Year).Name("Data");
            Map(m => m.NetProduction).Name("CDEEBC_ProdNeta");
            Map(m => m.GasolineConsumption).Name("CCAC_GasolinaAuto");
            Map(m => m.ElectricDemand).Name("CDEEBC_DemandaElectr");
            Map(m => m.AvailableProduction).Name("CDEEBC_ProdDisp");
        }
    }
}
