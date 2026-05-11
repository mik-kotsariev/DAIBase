using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DaiBase.Models;

namespace DaiBase.Services
{
    public class JsonDataStorage
    {
        private readonly string _filePath;

        public JsonDataStorage(string fileName = "data.json")
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        public void Save(List<Vehicle> vehicles)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(vehicles, options);
            File.WriteAllText(_filePath, jsonString);
        }

        public List<Vehicle> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Vehicle>();

            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Vehicle>>(jsonString) ?? new List<Vehicle>();
        }
    }
}