using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class WindSystem: EnergySystem, IEnergyCalculation
    {
        private double windSpeed;

        public WindSystem() : base("Eòlic") { }

        public override void SetParameters()
        {
            Console.Write("Introdueix la velocitat del vent (> 5 m/s): ");
            windSpeed = UserInteractionHelper.UserDoubleInput(5);
        }

        public override double CalculateEnergy()
        {
            return Math.Pow(windSpeed, 3) * 0.2;
        }

    }
}