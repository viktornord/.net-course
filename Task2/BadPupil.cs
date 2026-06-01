namespace Task2;

public class BadPupil : Pupil
{
    public override void Study() =>
        Console.WriteLine("Studies rarely and often forgets to prepare for class.");

    public override void Read() =>
        Console.WriteLine("Reads only the first page and loses interest quickly.");

    public override void Write() =>
        Console.WriteLine("Writes messy notes with many spelling errors.");

    public override void Relax() =>
        Console.WriteLine("Relaxes instead of doing homework and arrives unprepared.");
}
