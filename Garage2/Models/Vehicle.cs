using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Regnr { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public int Wingspan { get; set; }
        public int NumberOfPropellers { get; set; }
        public bool HasMuffler { get; set; }
        public int CubicCentimeter { get; set; }
        public int HorsePower { get; set; }
        public bool IsCabriolet { get; set; }
        public int PassengerCapacity { get; set; }
        public int BusNumber { get; set; }
        public int MaxKnotSpeed { get; set; }
        public bool isSailingboat { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

    }
    public enum VehicleType
    {
        Car,
        Airplane,
        Boat,
        Bus,
        Motorcycle
    }



}