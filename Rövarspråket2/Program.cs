using System;
using System.Text.RegularExpressions;

class RobberSpeak
{
    static void Main(string[] args)
    {
        string input = String.Join(" ", args);
        Regex regex = new Regex("(?i)[b-df-hj-np-tv-xz]");
        Console.WriteLine(regex.Replace(input, new MatchEvaluator(Robberify)));
    }

    static string Robberify(Match m)
    {
        return m.Value + "o" + m.Value.ToLower();
    }
}