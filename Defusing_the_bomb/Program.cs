using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Defusing_the_bomb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 colours of cables you want to connect.");
            string[] input = new string[4];
            char[] colour = new char[4];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
                if (input[i] == "white") colour[i] = 'w';
                else if (input[i] == "red") colour[i] = 'r';
                else if (input[i] == "black") colour[i] = 'b';
                else if (input[i] == "orange") colour[i] = 'o';
                else if (input[i] == "green") colour[i] = 'g';
                else if (input[i] == "purple") colour[i] = 'p';
                else Console.WriteLine("Enter valid colours");
                sb.Append(colour[i]);
            }
            ValidateInput(sb.ToString());
            Console.ReadKey();
        }

        private static void ValidateInput(string input)
        {
            Regex myRegex = new Regex("ww|wb|rg|bw|bg|bo|or|ob|go|gy|pp|pg|po|py");
            Match match = myRegex.Match(input);
            if (match.Success)
            {
                Console.WriteLine("Boom!");
            }
            else
            {
                Console.WriteLine("Bomb has been defused.");
            }
        }
    }
}