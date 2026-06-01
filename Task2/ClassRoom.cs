namespace Task2;

public class ClassRoom
{
    private readonly Pupil[] _pupils;

    public ClassRoom(Pupil pupil1, Pupil pupil2)
    {
        _pupils = [pupil1, pupil2];
    }

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
    {
        _pupils = [pupil1, pupil2, pupil3];
    }

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
    {
        _pupils = [pupil1, pupil2, pupil3, pupil4];
    }

    public void ShowActivities()
    {
        for (var i = 0; i < _pupils.Length; i++)
        {
            var pupil = _pupils[i];
            Console.WriteLine($"Student {i + 1} ({pupil.GetType().Name}):");
            Console.WriteLine("  Studies:");
            pupil.Study();
            Console.WriteLine("  Reads:");
            pupil.Read();
            Console.WriteLine("  Writes:");
            pupil.Write();
            Console.WriteLine("  Relaxes:");
            pupil.Relax();
            Console.WriteLine();
        }
    }
}
