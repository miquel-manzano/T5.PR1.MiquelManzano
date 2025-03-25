using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationsLibrary
{
    public interface IEnergyCalculation
    {
        void SetParameters();
        double CalculateEnergy();
    }
}