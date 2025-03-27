using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using System.Globalization;

namespace EcoEnergySolutions.Utils
{
    public class CsvHandling
    {
        public static List<EnergyIndicator> ReadEnergyIndicatorCsv(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null, // Ignora validación de headers
                MissingFieldFound = null // Ignora campos faltantes
            };

            using var reader = new StreamReader(filePath);
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<EnergyIndicatorsCsvMap>();
                return csv.GetRecords<EnergyIndicator>().ToList();
            }
        }
        public static List<WaterConsumption> ReadWaterConsumptionCsv(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null, // Ignora validación de headers
                MissingFieldFound = null // Ignora campos faltantes
            };

            using var reader = new StreamReader(filePath);
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<WaterConsumptionsCsvMap>();
                return csv.GetRecords<WaterConsumption>().ToList();
            }
        }
    }
}
