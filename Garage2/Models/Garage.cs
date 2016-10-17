using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    // The Vehicles is stored here
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicle;
        public int Capacity { get; set; }
        public int Count { get; private set; }
        public int Id { get; set; }
        //public string Name { get; set; }
        //public int Placing { get; set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicle = new T[capacity];
        }

        public bool AddVehicle(T item)
        {
            if (Count >= Capacity)
            {
                return false;
            }
            vehicle[Count] = item;
            Count++;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return vehicle[i];
            }
        }

    }
}