using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    internal class Garage<T> : IEnumerable<T>, IGarage<T> where T : Vehicle
    {
        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
