using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Boat : Vehicle
    {
        double Lenght;
        public Boat(string registrationNumber, string color, int numberOfWheels, double lenght)
        {
            Lenght = lenght;
        }

        public Boat()
        {
        }
    }
}
