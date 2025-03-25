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
        public DateTime Year { get; set; }
        public Double? Consumption { get; set; }
    }
}
