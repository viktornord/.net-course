namespace Task6;

internal static class Program
{
    private static void Main()
    {
        (Word From, Word To)[] entries =
        [
            (new Word("ua", "привіт"), new Word("en", "hello")),
            (new Word("ua", "до побачення"), new Word("en", "goodbye")),
            (new Word("ua", "книга"), new Word("en", "book")),
            (new Word("ua", "місто"), new Word("en", "city")),
            (new Word("ua", "будинок"), new Word("en", "house")),
            (new Word("ua", "друг"), new Word("en", "friend")),
            (new Word("ua", "сім'я"), new Word("en", "family")),
            (new Word("ua", "вчитель"), new Word("en", "teacher")),
            (new Word("ua", "студент"), new Word("en", "student")),
            (new Word("ua", "школа"), new Word("en", "school"))
        ];

        var dictionary = new UkraineEnglishDictionary(entries);

        Console.WriteLine("Ukraine-English Dictionary");
        Console.WriteLine("Choose a language and search by word.");
        Console.WriteLine("Type \"exit\" to quit.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Available languages: ua, en");
            Console.Write("Choose language: ");
            string? selectedLanguage = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(selectedLanguage))
            {
                Console.WriteLine("Please choose a language.");
                continue;
            }

            selectedLanguage = selectedLanguage.Trim();
            if (string.Equals(selectedLanguage, "exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (selectedLanguage != "ua" && selectedLanguage != "en")
            {
                Console.WriteLine("This language is not available.");
                continue;
            }

            string[] availableWords = entries
                .SelectMany(pair => new[] { pair.From, pair.To })
                .Where(word => string.Equals(word.Lang, selectedLanguage, StringComparison.OrdinalIgnoreCase))
                .Select(word => word.Value)
                .ToArray();

            Console.WriteLine($"Available words in [{selectedLanguage}]: {string.Join(", ", availableWords)}");
            Console.Write("Enter a word: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a non-empty word.");
                continue;
            }

            input = input.Trim();
            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (!availableWords.Contains(input, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Word \"{input}\" is not available in [{selectedLanguage}].");
                continue;
            }

            Word[] translations = dictionary.FindTranslations(input);
            if (translations.Length == 0)
            {
                Console.WriteLine("No translations found.");
                continue;
            }

            Console.WriteLine("Translations:");
            foreach (Word translation in translations)
            {
                Console.WriteLine($"- [{translation.Lang}] {translation.Value}");
            }
        }
    }
}
