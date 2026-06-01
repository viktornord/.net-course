namespace Task3;

public class Ship : Vehicle
{
    protected int NumberOfPassengers;
    protected string HomePort;

    public Ship(
        (double x, double y) coordinates,
        decimal price,
        double speed,
        int yearOfManufacture,
        int numberOfPassengers,
        string homePort)
        : base(coordinates, price, speed, yearOfManufacture)
    {
        NumberOfPassengers = numberOfPassengers;
        HomePort = homePort;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Ship:");
        base.DisplayInfo();
        Console.WriteLine($"  Number of passengers: {NumberOfPassengers}");
        Console.WriteLine($"  Home port: {HomePort}");
    }
}
