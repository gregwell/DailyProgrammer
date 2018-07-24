public class Translator
{
    public static readonly char[] Consonants = new char[]{'b', 'c', 'd', 'f', 'g', 'h', 'j',
            'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'};

    private StringBuilder OutputStringBuilder = new StringBuilder();

    public string Encode(string input)
    {
        OutputStringBuilder.Clear();
        foreach (var character in input)
        {
            OutputStringBuilder.Append(
                (character.IsConsonant())
                ? character + "o" + char.ToLower(character)
                : character.ToString()
                );
        }
        return OutputStringBuilder.ToString();
    }

    public string Decode(string input)
    {
        return Regex.Replace(input, @"(\w)o\1", "$1", RegexOptions.IgnoreCase);
    }
}

public static class ExtensionMethods
{
    public static bool IsConsonant(this char character)
    {
        return (char.IsLetter(character) && Translator.Consonants.Contains(char.ToLower(character)));
    }
}