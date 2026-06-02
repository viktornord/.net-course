namespace Task3;

public class Player : IPlayable, IRecodable
{
    public void Play()
    {
        Console.WriteLine("Playing media...");
    }

    public void Record()
    {
        Console.WriteLine("Recording media...");
    }

    void IPlayable.Pause()
    {
        Console.WriteLine("Playback paused.");
    }

    void IPlayable.Stop()
    {
        Console.WriteLine("Playback stopped.");
    }

    void IRecodable.Pause()
    {
        Console.WriteLine("Recording paused.");
    }

    void IRecodable.Stop()
    {
        Console.WriteLine("Recording stopped.");
    }
}
