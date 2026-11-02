namespace AutoServiceApp
{
    public interface IServiceable
    {
        string Model { get; }
        decimal GetServiceCost();
    }
}