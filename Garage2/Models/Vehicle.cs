using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Regnr { get; set; }
        public string Color { get; set; }
        [Display(Name = "Wheels")]
        public int NumberOfWheels { get; set; }
        public int Wingspan { get; set; }
        [Display(Name = "No. of propellers")]
        public int NumberOfPropellers { get; set; }
        [Display(Name = "Muffler")]
        public bool HasMuffler { get; set; }
        [Display(Name = "cm³")]
        public int CubicCentimeter { get; set; }
        [Display(Name = "hp")]
        public int HorsePower { get; set; }
        [Display(Name = "Cabriolet")]
        public bool IsCabriolet { get; set; }
        [Display(Name = "Capacity")]
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
        Select,
        Car,
        Airplane,
        Boat,
        Bus,
        Motorcycle
    }



}