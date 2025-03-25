using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergySolutions.Models
{
    [Table("EnergyIndicators")]
    public class EnergyIndicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public Double? NetProduction { get; set; }
        public Double? GasolineConsumption { get; set; }
        public Double? ElectricDemand { get; set; }
        public Double? AvailableProduction { get; set; }
    }
}
