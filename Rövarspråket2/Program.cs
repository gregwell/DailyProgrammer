using System;
using System.Text.RegularExpressions;

internal class RobberSpeak
{
    private static void Main(string[] args)
    {
        string input = String.Join(" ", args);
        Regex regex = new Regex("(?i)[b-df-hj-np-tv-xz]");
        Console.WriteLine(regex.Replace(input, new MatchEvaluator(Robberify)));
    }

    private static string Robberify(Match m)
    {
        return m.Value + "o" + m.Value.ToLower();
    }
}