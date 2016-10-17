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
        public VehicleType VehicleType { get; set; }
        public DateTime Checkin { get; set; }

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