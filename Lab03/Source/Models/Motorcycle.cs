namespace AutoServiceApp.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, string model, int year, bool hasSidecar = false)
            : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override decimal CalculateServiceCost() => HasSidecar ? 1200m : 800m;

        public override void DisplayInfo()
        {
            string sidecarStr = HasSidecar ? "з коляскою" : "без коляски";
            string status = IsUnderRepair ? "В ремонті" : "Готовий";
            Console.WriteLine($"[Мотоцикл] {Brand} {Model} ({Year} р.), {sidecarStr} - Стан: {status} | ТО: {CalculateServiceCost()} грн");
        }
    }
}