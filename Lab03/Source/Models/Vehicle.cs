namespace AutoServiceApp.Models
{
    public abstract class Vehicle
    {
        private string _brand = string.Empty;
        private string _model = string.Empty;
        private int _year;

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Марка не може бути порожньою.");
                _brand = value;
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Модель не може бути порожньою.");
                _model = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1886 || value > DateTime.Now.Year + 1)
                    throw new ArgumentException("Некоректний рік випуску.");
                _year = value;
            }
        }

        public bool IsUnderRepair { get; private set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            IsUnderRepair = false;
        }

        public void StartRepair() => IsUnderRepair = true;
        public void FinishRepair() => IsUnderRepair = false;

        public abstract decimal CalculateServiceCost();

        public virtual void DisplayInfo()
        {
            string status = IsUnderRepair ? "В ремонті" : "Готовий";
            Console.WriteLine($"[ТЗ] {Brand} {Model} ({Year} р.) - Стан: {status}");
        }
    }
}