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
                Console.WriteLine("throw the dice {0} times, {1}-sided dice",match.Groups[1], match.Groups[2]);
                Random random = new Random();

                StringBuilder sb = new StringBuilder();
                int counter = 0;

                for (int i = 0; i < Int32.Parse(match.Groups[1].Value); i++)
                {
                    var result = random.Next(1, Int32.Parse(match.Groups[2].Value));
                    sb.Append(result).Append(' ');
                    counter += result;
                }
                Console.WriteLine("{0}: {1}", counter, sb);
            }
            else
            {
                Console.WriteLine("huja wyszlo");
            }
            Console.ReadKey();
        }
    }
}