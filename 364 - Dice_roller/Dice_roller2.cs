using System;
using System.Linq;

namespace DnDDiceRoller
{
    class Program
    {
        static Random rand = new Random();
        static Func<string, int> DiceRoll =>
            (x) => Enumerable.Range(0, int.Parse(x.Split('d')[0]))
            .Select(y => rand.Next(1, int.Parse(x.Split('d')[1]) + 1))
            .Sum();

        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine(DiceRoll(Console.ReadLine()));
            }
        }
    }
}