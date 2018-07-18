using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rövarspråket
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter message you want to encode");
            string message = Console.ReadLine();

            Encode(message);

            Console.ReadKey();
        }

        private static void Encode(string text)
        {
            char[] position = text.ToCharArray();


            bool isVowel = "aeiouyAEIOUYåäöÅÄÖ".IndexOf(position[0]) != -1;

            Console.WriteLine(isVowel);
        }
    }
}