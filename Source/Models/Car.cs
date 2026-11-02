namespace AutoServiceApp.Models
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }

        public Car(string brand, string model, int year, int doorsCount = 4)
            : base(brand, model, year)
        {
            DoorsCount = doorsCount;
        }

        public override decimal CalculateServiceCost() => 1500m;

        public override void DisplayInfo()
        {
            string status = IsUnderRepair ? "В ремонті" : "Готовий";
            Console.WriteLine($"[Легковий авто] {Brand} {Model} ({Year} р.), дверей: {DoorsCount} - Стан: {status} | ТО: {CalculateServiceCost()} грн");
        }
    }
}