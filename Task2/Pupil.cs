namespace Task2;

public class Pupil
{
    public virtual void Study() =>
        Console.WriteLine("Studies at an average pace.");

    public virtual void Read() =>
        Console.WriteLine("Reads the assigned material.");

    public virtual void Write() =>
        Console.WriteLine("Writes standard class notes.");

    public virtual void Relax() =>
        Console.WriteLine("Relaxes during the break.");
}
