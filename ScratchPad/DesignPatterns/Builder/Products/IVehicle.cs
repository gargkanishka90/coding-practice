namespace ScratchPad.DesignPatterns.Builder.Products
{
    public interface IVehicle
    {
        int NumTires { get; set; }
        string Color { get; set; }
        bool AirConditioned { get; set; }
        string Name { get; set; }
    }
}