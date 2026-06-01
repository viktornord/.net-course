namespace Task2;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Classroom with 2 students ===");
        var classroom2 = new ClassRoom(new ExcellentPupil(), new BadPupil());
        classroom2.ShowActivities();

        Console.WriteLine("=== Classroom with 3 students ===");
        var classroom3 = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil());
        classroom3.ShowActivities();

        Console.WriteLine("=== Classroom with 4 students ===");
        var classroom4 = new ClassRoom(
            new ExcellentPupil(),
            new GoodPupil(),
            new GoodPupil(),
            new BadPupil());
        classroom4.ShowActivities();
    }
}
