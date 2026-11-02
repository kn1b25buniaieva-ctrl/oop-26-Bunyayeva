using System;
using System.Collections.Generic;
using AutoServiceApp.Models;

namespace AutoServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ЛАБОРАТОРНА РОБОТА #4: ІНТЕРФЕЙСИ ТА КОМПОЗИЦІЯ ===");

            // 1. Поліморфна робота через інтерфейс IServiceable
            List<IServiceable> serviceItems = new List<IServiceable>
            {
                new Car("Toyota", "Camry", 2021, 4),
                new Truck("Volvo", "FH16", 2019, 18.5),
                new Motorcycle("BMW", "R1250", 2022, false),
                new Car("BMW", "X5", 2023, 5)
            };

            Console.WriteLine("\n--- Обробка ТЗ через інтерфейс IServiceable ---");
            decimal totalBatchCost = 0;

            foreach (IServiceable item in serviceItems)
            {
                decimal cost = item.GetServiceCost();
                Console.WriteLine($"ТЗ: {item.Model} | Розрахована вартість: {cost} грн");
                totalBatchCost += cost;
            }

            Console.WriteLine($"\nЗагальна вартість обслуговування партії: {totalBatchCost} грн");

            // 2. Демонстрація Композиції (ServiceOrder)
            Customer customer = new Customer("Олексій Коваленко", "+380971112233");
            Car customerCar = new Car("BMW", "X5", 2023, 5);

            ServiceOrder order = new ServiceOrder(customer, customerCar);
            order.AddOperation("Діагностика підвіски");
            order.AddOperation("Заміна оливи та фільтрів");
            order.AddOperation("Балансування коліс");

            order.DisplayOrderInfo();
        }
    }
}