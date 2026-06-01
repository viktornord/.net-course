namespace Task3;

public class Car : Vehicle
{
    public Car((double x, double y) coordinates, decimal price, double speed, int yearOfManufacture)
        : base(coordinates, price, speed, yearOfManufacture)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Car:");
        base.DisplayInfo();
    }
}
