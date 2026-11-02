namespace AutoServiceApp
{
    public abstract class Vehicle : IServiceable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsUnderRepair { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            IsUnderRepair = false;
        }

        public abstract decimal CalculateServiceCost();

        // Реалізація методу з інтерфейсу IServiceable
        public decimal GetServiceCost()
        {
            return CalculateServiceCost();
        }

        public virtual void DisplayInfo()
        {
            string status = IsUnderRepair ? "В ремонті" : "Готовий";
            System.Console.WriteLine($"[{GetType().Name}] {Brand} {Model} ({Year} р.) - Стан: {status} | ТО: {GetServiceCost()} грн");
        }
    }
}