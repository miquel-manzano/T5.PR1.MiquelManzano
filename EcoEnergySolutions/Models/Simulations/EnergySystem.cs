using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public abstract class EnergySystem : IEnergyCalculation
    {
        public string SystemName {  get; set; }
        public DateTime SimulationDate { get; set; }
        public string? SimulationType { get; set; }

        protected EnergySystem(string SystemName)
        {
            this.SystemName = SystemName;
            this.SimulationDate = DateTime.Now;
        }

        public abstract void SetParameters();
        public abstract double CalculateEnergy();

        public override string ToString()
        {
            return $"{SimulationDate:G}\t{SystemName}\t{CalculateEnergy():F2} kWh";
        }
    }
}