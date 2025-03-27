using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergySolutions.Models
{
    public enum SimulationType
    {
        SolarEnergy,
        WindEnergy,
        WaterEnergy
    }

    [Table("Simulations")]
    public class Simulation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public SimulationType Type { get; set; }
        public int SunHours { get; set; }
        public double WindSpeed { get; set; }
        public double WaterFlow { get; set; }
        public double Ratio { get; set; }
        public double GeneratedEnergy { get; set; }
        public double KWhCost { get; set; }
        public double KWhPrice { get; set; }
        // Funciona a medias https://learn.microsoft.com/es-es/dotnet/api/system.web.ui.webcontrols.boundfield.dataformatstring?view=netframework-4.8
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
