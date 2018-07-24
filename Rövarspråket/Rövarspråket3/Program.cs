using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            string robber = ToRobber(arg);
            Console.WriteLine(robber);
        }
    }

    public static string ToRobber(string s)
    {
        char[] characters = s.ToCharArray();
        StringBuilder sb = new StringBuilder();
        foreach (char c in characters)
        {
            if (Char.IsLetter(c) && IsConsonant(c))
            {
                sb.Append(c).Append('o').Append(Char.ToLower(c));
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    public static bool IsConsonant(char c)
    {
        return "bcdfghjklmnpqrstvwxz".IndexOf(Char.ToLower(c)) >= 0;
    }
}