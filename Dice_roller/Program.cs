using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Dice_roller
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex myRegex = new Regex(@"^([1-9][0-9]{0,1}|100)d([1-9][0-9]|100|[2-9])\b$");
            Match match = myRegex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("here we go");
                Console.WriteLine(match.Groups[1]);
                Console.WriteLine(match.Groups[2]);
            }
            else
            {
                Console.WriteLine("huja wyszlo");
            }
            Console.ReadKey();
        }
    }
}