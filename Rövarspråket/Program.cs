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

            for (int i=0; i<text.Length; i++)
            {
                bool isVowel = "aeiouyAEIOUYåäöÅÄÖ".IndexOf(position[i]) != -1 ;

                if (isVowel)
                {
                    Console.WriteLine("{0}", position[i]);
                }
                else
                {
                    Console.WriteLine("{0}o{0}", position[i]);
                }
            }
        }
    }
}