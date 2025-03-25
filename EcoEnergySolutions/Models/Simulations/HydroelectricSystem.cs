using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class HydroelectricSystem: EnergySystem, IEnergyCalculation
    {
        private double waterFlow;

        public HydroelectricSystem() : base("Hidroelèctric") { }

        public override void SetParameters()
        {
            Console.Write("Introdueix el cabal de l’aigua (> 20 m3): ");
            waterFlow = UserInteractionHelper.UserDoubleInput(20);
        }

        public override double CalculateEnergy()
        {
            return waterFlow * 9.8 * 0.8;
        }

    }
}