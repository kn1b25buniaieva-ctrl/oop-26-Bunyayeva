using System;
using System.Collections.Generic;
using AutoServiceApp.Models;

namespace AutoServiceApp
{
    public class ServiceOrder
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        private readonly List<string> _operations = new();

        public ServiceOrder(Customer customer, Vehicle vehicle)
        {
            Customer = customer;
            Vehicle = vehicle;
        }

        public void AddOperation(string operationName)
        {
            _operations.Add(operationName);
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine("\n=== ЗАМОВЛЕННЯ-НАРЯД (КОМПОЗИЦІЯ) ===");
            Console.WriteLine($"Клієнт: {Customer.Name} (Тел: {Customer.Phone})");
            Console.WriteLine($"Транспортний засіб: {Vehicle.Model}");
            Console.WriteLine("Перелік робіт:");
            foreach (var op in _operations)
            {
                Console.WriteLine($"  - {op}");
            }
            Console.WriteLine($"Загальна вартість: {Vehicle.GetServiceCost()} грн");
        }
    }
}