namespace Task3;

public class Vehicle
{
    protected (double X, double Y) Coordinates;
    protected decimal Price;
    protected double Speed;
    protected int YearOfManufacture;

    public Vehicle((double x, double y) coordinates, decimal price, double speed, int yearOfManufacture)
    {
        Coordinates = coordinates;
        Price = price;
        Speed = speed;
        YearOfManufacture = yearOfManufacture;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"  Coordinates: ({Coordinates.X}, {Coordinates.Y})");
        Console.WriteLine($"  Price: {Price:C}");
        Console.WriteLine($"  Speed: {Speed} km/h");
        Console.WriteLine($"  Year of manufacture: {YearOfManufacture}");
    }
}
