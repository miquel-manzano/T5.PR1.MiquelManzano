using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergySolutions.Models
{
    [Table("WaterConsumptions")]
    public class WaterConsumption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? County { get; set; }
        public int? Population { get; set; }
        [Range(1800, 2025)]
        public int Year { get; set; }
        [Range(0.00f, 10000.00f)]
        public Double? Consumption { get; set; }
    }
}
