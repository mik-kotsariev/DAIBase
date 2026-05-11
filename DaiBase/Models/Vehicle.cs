using System;

namespace DaiBase.Models
{
    public enum VehicleType
    {
        Car,
        Truck,
        Motorcycle,
        Trailer
    }

    public class Vehicle
    {
        public string StateNumber { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int ManufactureYear { get; set; }
        public VehicleType Type { get; set; }
        public string SpecialFeatures { get; set; }
        public DateTime LastInspectionDate { get; set; }


        public Owner VehicleOwner { get; set; }


        public bool IsInspectionOverdue
        {
            get
            {
                return DateTime.Now > LastInspectionDate.AddYears(2);
            }
        }
    }
}