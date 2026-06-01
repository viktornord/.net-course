namespace Task2;

public class GoodPupil : Pupil
{
    public override void Study() =>
        Console.WriteLine("Studies regularly and keeps up with the class.");

    public override void Read() =>
        Console.WriteLine("Reads the textbook chapters on time.");

    public override void Write() =>
        Console.WriteLine("Writes neat homework with few mistakes.");

    public override void Relax() =>
        Console.WriteLine("Relaxes with friends after finishing homework.");
}
