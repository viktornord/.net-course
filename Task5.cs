namespace DotNetCourse;

/// <summary>
/// Task 5: Ukrainian–English translator for 10 weather-related words.
/// </summary>
public static class Task5
{
    private static readonly Dictionary<string, string> Translations = new(StringComparer.OrdinalIgnoreCase)
    {
        ["сонце"] = "sun",
        ["дощ"] = "rain",
        ["сніг"] = "snow",
        ["вітер"] = "wind",
        ["хмара"] = "cloud",
        ["гроза"] = "thunderstorm",
        ["туман"] = "fog",
        ["блискавка"] = "lightning",
        ["спека"] = "heat",
        ["мороз"] = "frost",
    };

    public static void Run()
    {
        Console.WriteLine("Ukrainian–English weather translator (10 words).");
        Console.WriteLine("Known words: {0}", string.Join(", ", Translations.Keys));
        Console.Write("Enter a word in Ukrainian: ");
        string? word = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("No word entered.");
            return;
        }

        word = word.Trim();

        if (Translations.TryGetValue(word, out string? english))
        {
            Console.WriteLine("Translation: {0}", english);
        }
        else
        {
            Console.WriteLine("There is no translation for the word \"{0}\".", word);
        }
    }
}
