using System;

namespace DaiBase.Models
{
    // Клас власника авто 
    public class Owner
    {
        //ПІБ
        public string? FullName { get; set; }
        // Номер паспорта
        public string? PassportNumber { get; set; }
    }
}