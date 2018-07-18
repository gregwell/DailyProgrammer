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

            char[] array = new char[50];

            for (int i = 0; i < text.Length; i++)
            {
                bool isVowel = "aeiouyAEIOUYåäöÅÄÖ".IndexOf(position[i]) != -1;
                int counter = 0;
                if (isVowel)
                {
                    counter++;
                    array[counter] = position[i];
                    Console.WriteLine(" (samogloska) ");
                }
                else
                {
                    counter += 1;
                    array[counter] = position[i];
                    counter += 1;
                    array[counter] = 'o';
                    counter += 1;
                    array[counter] = position[i];
                    Console.WriteLine(" (spolgloska) ");
                }
            }

            for (int j = 1; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
            //   string encoded = new string(array);
            // Console.WriteLine(encoded);
        }
    }
}