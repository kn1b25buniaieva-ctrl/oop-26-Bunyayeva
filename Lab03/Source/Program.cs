using System.Text;
using AutoServiceApp.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== Лабораторна робота №3: Успадкування та поліморфізм ===");
Console.WriteLine("=== Облік та розрахунок вартістей сервісу ===\n");

List<Vehicle> vehicles = new List<Vehicle>
{
    new Car("Toyota", "Camry", 2021, 4),
    new Truck("Volvo", "FH16", 2019, 18.5),
    new Motorcycle("BMW", "R1250", 2022, false),
    new Car("BMW", "X5", 2023, 5),
    new Motorcycle("Dnipro", "MT-11", 1992, true)
};

vehicles[1].StartRepair();
vehicles[3].StartRepair();

decimal totalServiceCost = 0m;

Console.WriteLine("--- Перелік усіх транспортних засобів у сервісі ---");
foreach (Vehicle vehicle in vehicles)
{
    vehicle.DisplayInfo();
    totalServiceCost += vehicle.CalculateServiceCost();
}

Console.WriteLine($"\nЗагальна вартість обслуговування всіх ТЗ: {totalServiceCost} грн");