using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Motorcycle : Vehicle
    {
        int CylinderVolume { get; set; }
        public Motorcycle() { }
        public Motorcycle(string registrationNumber, string color, int numberOfWheels, int cylinderVolume)
        {
            CylinderVolume = cylinderVolume;
        }

    }
}
