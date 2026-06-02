namespace Task3;

internal static class Program
{
    private static void Main()
    {
        Player player = new();

        Console.WriteLine("Playing:");
        player.Play();
        ((IPlayable)player).Pause();
        ((IPlayable)player).Stop();

        Console.WriteLine();
        Console.WriteLine("Recording:");
        player.Record();
        ((IRecodable)player).Pause();
        ((IRecodable)player).Stop();
    }
}
