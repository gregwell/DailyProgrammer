using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Input strings.
        const string s1 = "marcus aurelius";
        const string s2 = "the golden bowl";
        const string s3 = "Thomas jefferson";

        // Write output strings.
        Console.WriteLine(TextTools.UpperFirst(s1));
        Console.WriteLine(TextTools.UpperFirst(s2));
        Console.WriteLine(TextTools.UpperFirst(s3));
    }
}

public static class TextTools
{
    /// <summary>
    /// Uppercase first letters of all words in the string.
    /// </summary>
    public static string UpperFirst(string s)
    {
        // marcus aurelius, regex check match1: "marcus" match2: "aurelius"
        return Regex.Replace(s, @"\b[a-z]\w+", delegate (Match match)
        {
            string v = match.ToString();
            return char.ToUpper(v[0]) + v.Substring(1);
        });
    }
}
