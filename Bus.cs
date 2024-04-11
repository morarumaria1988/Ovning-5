using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Bus : Vehicle
    {
        public Bus() { }
        int NumberOfSeats { get; set; }
        public Bus(string registrationNumber, string color, int numberOfWheels, int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
