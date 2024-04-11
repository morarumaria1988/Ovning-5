using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Car
    {
        FuelType fuelType {  get; set; }
        public Car() { }
        public Car(string registrationNumber, string color, int numberOfWheels, FuelType fuelType)
        {
            this.fuelType = fuelType;
        }
    }

    enum FuelType
    {
        Gasoline,
        Diesel
    }
}
