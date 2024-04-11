using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Airplane : Vehicle
    {
        int NumberOfEngines { get; set; }
        public Airplane() { }
        public Airplane(string registrationNumber, string color, int numberOfWheels, int numberOfEngines)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
