namespace Task6;

internal sealed class Word
{
    public Word(string lang, string value)
    {
        Lang = lang.Trim();
        Value = value.Trim();
    }

    public string Lang { get; }

    public string Value { get; }
}
