namespace AutoServiceApp.Models
{
    public class Truck : Vehicle
    {
        public double LoadCapacityTons { get; set; }

        public Truck(string brand, string model, int year, double loadCapacityTons)
            : base(brand, model, year)
        {
            LoadCapacityTons = loadCapacityTons;
        }

        public override decimal CalculateServiceCost() => 3000m + (decimal)(LoadCapacityTons * 200);

        public override void DisplayInfo()
        {
            string status = IsUnderRepair ? "В ремонті" : "Готовий";
            Console.WriteLine($"[Вантажівка] {Brand} {Model} ({Year} р.), вантажопідйомність: {LoadCapacityTons} т - Стан: {status} | ТО: {CalculateServiceCost()} грн");
        }
    }
}