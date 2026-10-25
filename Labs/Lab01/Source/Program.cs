using AutoServiceApp.Models;

// 1. Створення двох об'єктів автомобілів (клас Car)
Car car1 = new()
{
    Brand = "Toyota",
    Model = "Camry",
    Year = 2020
};

Car car2 = new()
{
    Brand = "BMW",
    Model = "X5",
    Year = 2022
};

// 2. Створення двох об'єктів клієнтів (клас Customer)
Customer customer1 = new()
{
    Name = "Олександр Коваль"
};

Customer customer2 = new()
{
    Name = "Олена Бойко"
};

// 3. Виведення інформації у консоль
Console.WriteLine("=== Автомобілі в сервісі ===");
Console.WriteLine($"{car1.Brand} {car1.Model} ({car1.Year} р.)");
Console.WriteLine($"{car2.Brand} {car2.Model} ({car2.Year} р.)");

Console.WriteLine("\n=== Власники (Клієнти) ===");
Console.WriteLine($"Клієнт: {customer1.Name}");
Console.WriteLine($"Клієнт: {customer2.Name}");