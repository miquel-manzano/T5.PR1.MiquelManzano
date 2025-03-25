using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public class SolarSystem: EnergySystem, IEnergyCalculation
    {
        private double SunHours;

        public SolarSystem() : base("Solar") { }

        public override void SetParameters()
        {
            Console.Write("Introdueix les hores de sol disponibles (> 1): ");
            SunHours = UserInteractionHelper.UserDoubleInput(1);//user library
        }

        public override double CalculateEnergy()
        {
            return SunHours * 1.5;
        }
    }
}