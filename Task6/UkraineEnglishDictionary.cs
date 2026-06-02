namespace Task6;

internal sealed class UkraineEnglishDictionary
{
    private readonly Dictionary<string, List<Word>> _translationsByValue = new(StringComparer.OrdinalIgnoreCase);

    public UkraineEnglishDictionary(IEnumerable<(Word From, Word To)> translations)
    {
        foreach ((Word from, Word to) in translations)
        {
            AddDirectional(from, to);
            AddDirectional(to, from);
        }
    }

    public Word[] FindTranslations(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return [];
        }

        string input = query.Trim();
        if (!_translationsByValue.TryGetValue(input, out List<Word>? translations))
        {
            return [];
        }

        return [..translations];
    }

    private void AddDirectional(Word from, Word to)
    {
        if (!_translationsByValue.TryGetValue(from.Value, out List<Word>? list))
        {
            list = [];
            _translationsByValue[from.Value] = list;
        }

        bool exists = list.Any(existing =>
            string.Equals(existing.Lang, to.Lang, StringComparison.OrdinalIgnoreCase) &&
            string.Equals(existing.Value, to.Value, StringComparison.OrdinalIgnoreCase));

        if (!exists)
        {
            list.Add(to);
        }
    }
}
