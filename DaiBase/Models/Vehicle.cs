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
        public string StateNumber { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Color { get; set; } = "";
        public int ManufactureYear { get; set; }
        public VehicleType Type { get; set; }
        public string SpecialFeatures { get; set; } = "";
        public DateTime LastInspectionDate { get; set; }


        public Owner VehicleOwner { get; set; } = new Owner();


        public bool IsInspectionOverdue
        {
            get
            {
                return DateTime.Now > LastInspectionDate.AddYears(2);
            }
        }
        public string GenerateInspectionNotice()
        {
            return $"ОФІЦІЙНЕ ПОВІДОМЛЕННЯ\n\n" +
                   $"Шановний(а) {this.VehicleOwner.FullName}!\n" +
                   $"Згідно з базою даних, технічний огляд вашого ТЗ {this.Brand} " +
                   $"(Держ. номер: {this.StateNumber}) потребує оновлення.\n\n" +
                   $"Просимо з'явитися до найближчого сервісного центру МВС.\n" +
                   $"Дата формування: {DateTime.Now.ToShortDateString()}";
        }
    }
}