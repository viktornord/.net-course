namespace Task3;

internal static class Program
{
    private static void Main()
    {
        Vehicle[] vehicles =
        [
            new Car(
                coordinates: (55.75, 37.62),
                price: 25_000m,
                speed: 120,
                yearOfManufacture: 2022),
            new Plane(
                coordinates: (40.64, -73.78),
                price: 150_000_000m,
                speed: 850,
                yearOfManufacture: 2019,
                altitude: 10_000,
                numberOfPassengers: 180),
            new Ship(
                coordinates: (51.51, -0.13),
                price: 500_000_000m,
                speed: 35,
                yearOfManufacture: 2015,
                numberOfPassengers: 2_500,
                homePort: "Southampton")
        ];

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
