using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Motorcycle : Vehicle
    {
        double CylinderVolume { get; set; }
        public Motorcycle() { }
        public Motorcycle(string registrationNumber, string color, int numberOfWheels, double cylinderVolume)
        {
            CylinderVolume = cylinderVolume;
        }

    }
}
