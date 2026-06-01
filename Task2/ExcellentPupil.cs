namespace Task2;

public class ExcellentPupil : Pupil
{
    public override void Study() =>
        Console.WriteLine("Studies with exceptional focus and completes every assignment ahead of schedule.");

    public override void Read() =>
        Console.WriteLine("Reads advanced books and analyzes every detail.");

    public override void Write() =>
        Console.WriteLine("Writes clear, well-structured essays without errors.");

    public override void Relax() =>
        Console.WriteLine("Relaxes by reviewing notes and planning the next study session.");
}
