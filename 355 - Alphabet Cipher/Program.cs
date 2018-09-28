using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_Cipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //collect user input and divide to two strings.
            Console.WriteLine("Sample input: keyword messagetoencode");
            Console.Write("Your input: ");
            string[] input = Console.ReadLine().Trim().Split(' ');

            //extend keyword to length of message.
            var keyword = input[0];
            char[] kposition = input[0].ToCharArray();
            for (int i = 1; i < (input[1].Length / keyword.Length); i++) input[0] += keyword;
            for (int i = 0; i < (input[1].Length % keyword.Length); i++) input[0] += kposition[i];

            //make char arrays k and m.
            char[] k = input[0].ToCharArray();
            char[] m = input[1].ToCharArray();

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            // k[0] == 'c'
            // m[0] == 'd'
            // k[0] == alphabet[2]
            // m[0] == alphabet[3]
            //so result[0] = alphabet[2+3]

            int[] k_index = new int[input[0].Length];
            int[] m_index = new int[input[0].Length];

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < input[0].Length; j++)
                {
                    Console.WriteLine(input[0]);
                    if (k[j] == alphabet[i]) k_index[j] = i;
                    if (m[j] == alphabet[i]) m_index[j] = i;
                }
            }

            int[] result_index = new int[input[0].Length];

            Console.ReadKey();

            //handle also cases when the count is bigger than alphabet, then you have to reset index
            //25 is max
            //26 is 0
            //27 is 1 and so on...
        }
    }
}