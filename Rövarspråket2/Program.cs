using System;
using System.Text.RegularExpressions;

class RobberSpeak
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rövarspråket encoder..\nPlease enter message you want to encode");
        string message = Console.ReadLine();
        
        //connects multiple arguments into one
        //string input = String.Join(" ", message);
        

        Regex regex = new Regex("(?i)[b-df-hj-np-tv-xz]");
        Console.WriteLine(regex.Replace(message, new MatchEvaluator(Robberify)));
        
        Console.ReadKey();
    }

    static string Robberify(Match m)
    {
        return m.Value + "o" + m.Value.ToLower();
    }
}