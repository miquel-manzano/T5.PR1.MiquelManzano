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

        // Funciona a medias https://learn.microsoft.com/es-es/dotnet/api/system.web.ui.webcontrols.boundfield.dataformatstring?view=netframework-4.8
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        public Double? Consumption { get; set; }
    }
}
