namespace Task3;

public class Plane : Vehicle
{
    protected double Altitude;
    protected int NumberOfPassengers;

    public Plane(
        (double x, double y) coordinates,
        decimal price,
        double speed,
        int yearOfManufacture,
        double altitude,
        int numberOfPassengers)
        : base(coordinates, price, speed, yearOfManufacture)
    {
        Altitude = altitude;
        NumberOfPassengers = numberOfPassengers;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Plane:");
        base.DisplayInfo();
        Console.WriteLine($"  Altitude: {Altitude} m");
        Console.WriteLine($"  Number of passengers: {NumberOfPassengers}");
    }
}
