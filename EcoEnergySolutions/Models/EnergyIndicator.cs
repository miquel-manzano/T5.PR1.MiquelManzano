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

        // Funciona a medias https://learn.microsoft.com/es-es/dotnet/api/system.web.ui.webcontrols.boundfield.dataformatstring?view=netframework-4.8
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        [Required]
        [Range(0.00f, 10000.00f)]
        public Double NetProduction { get; set; }
        [Range(0.00f, 10000.00f)]
        public Double? GasolineConsumption { get; set; }
        [Range(0.00f, 10000.00f)]
        public Double? ElectricDemand { get; set; }
        [Range(0.00f, 10000.00f)]
        public Double? AvailableProduction { get; set; }
    }
}
