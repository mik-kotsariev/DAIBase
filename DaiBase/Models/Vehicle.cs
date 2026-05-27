using System;

namespace DaiBase.Models
{
    // Типи транспортних засобів
    public enum VehicleType
    {
        Car,
        Truck,
        Motorcycle,
        Trailer
    }

    // Клас транспортного засобу
    public class Vehicle
    {
        // Державний номер
        public string StateNumber { get; set; } = "";
        // Марка
        public string Brand { get; set; } = "";
        // Колір
        public string Color { get; set; } = "";
        // Рік випуску
        public int ManufactureYear { get; set; }
        // Тип транспортного засобу
        public VehicleType Type { get; set; }
        // Особливі примітки 
        public string SpecialFeatures { get; set; } = "";
        // Дата останнього технічного огляду
        public DateTime LastInspectionDate { get; set; }

        // Власник транспортного засобу
        public Owner VehicleOwner { get; set; } = new Owner();

        //чи прострочений технічний огляд > 2 років
        public bool IsInspectionOverdue
        {
            get
            {
                return DateTime.Now > LastInspectionDate.AddYears(2);
            }
        }
        //повідомлення про ТО
        public string GenerateInspectionNotice()
        {
            return $"ОФІЦІЙНЕ ПОВІДОМЛЕННЯ\n\n" +
                   $"Шановний(а) {this.VehicleOwner.FullName}!\n" +
                   $"Згідно з базою даних, технічний огляд вашого ТЗ {this.Brand} " +
                   $"(Держ. номер: {this.StateNumber}) потребує оновлення.\n\n" +
                   $"Просимо з'явитися до найближчого сервісного центру МВС.\n" +
                   $"Дата формування: {DateTime.Now.ToShortDateString()}";
        }

        // Отримати назву типу транспортного засобу
        public string GetVehicleTypeName()
        {
            switch (Type)
            {
                case VehicleType.Car: return "Легковий автомобіль";
                case VehicleType.Truck: return "Вантажний автомобіль";
                case VehicleType.Motorcycle: return "Мотоцикл";
                case VehicleType.Trailer: return "Причіп";
                default: return "Невідомо";
            }
        }
    }
}