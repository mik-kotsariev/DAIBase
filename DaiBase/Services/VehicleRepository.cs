using System;
using System.Collections.Generic;
using System.Linq;
using DaiBase.Models;

namespace DaiBase.Services
{
    // Репозиторій для управління транспортними засобами
    public class VehicleRepository
    {
        private List<Vehicle> _vehicles;
        private readonly JsonDataStorage _storage;

        public VehicleRepository()
        {
            _storage = new JsonDataStorage();
            _vehicles = _storage.Load();
        }
        public void AddVehicle(Vehicle vehicle)
        {

            if (_vehicles.Any(v => v.StateNumber == vehicle.StateNumber))
                throw new Exception("Транспортний засіб з таким номером вже існує!");

            _vehicles.Add(vehicle);
            SaveToFile();
        }


        public void DeleteVehicle(string stateNumber)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.StateNumber == stateNumber);
            if (vehicle != null)
            {
                _vehicles.Remove(vehicle);
                SaveToFile();
            }
        }


        public List<Vehicle> SearchVehicles(string number, string ownerName, string brand)
        {
            return _vehicles.Where(v =>
                (string.IsNullOrEmpty(number) || (v.StateNumber?.Contains(number, StringComparison.OrdinalIgnoreCase) ?? false)) &&
                (string.IsNullOrEmpty(ownerName) || (v.VehicleOwner?.FullName?.Contains(ownerName, StringComparison.OrdinalIgnoreCase) ?? false)) &&
                (string.IsNullOrEmpty(brand) || (v.Brand?.Contains(brand, StringComparison.OrdinalIgnoreCase) ?? false))
            ).ToList();
        }

        public List<Vehicle> GetOverdueInspections()
        {
            return _vehicles.Where(v => v.IsInspectionOverdue).ToList();
        }

        public List<Vehicle> GetAll() => _vehicles;

        public void SaveToFile() => _storage.Save(_vehicles);

        public void UpdateVehicle()
        {
            SaveToFile();
        }
    }
}