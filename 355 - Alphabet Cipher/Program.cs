using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Alphabet_Cipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //collect user input and divide to two strings.
            Console.WriteLine("Sample input: keyword_default messagetoencode");
            Console.Write("Your input: ");
            string input = Console.ReadLine();

            // regex
            var myRegex = new Regex(@"\b([a-z]+)\s([a-z]+)\b");
            Match match = myRegex.Match(input);

            while (!match.Success)
            {
                Console.WriteLine("Enter correct input");
                input = Console.ReadLine();
                match = myRegex.Match(input);
            }

            var keyword = match.Groups[1].Value;
            var message = match.Groups[2].Value;
            //extend keyword_default to length of message.
            var keyword_default = keyword;
            char[] kposition = keyword.ToCharArray();
            for (int i = 1; i < (keyword.Length / keyword_default.Length); i++) keyword += keyword_default;
            for (int i = 0; i < (message.Length % keyword_default.Length); i++) keyword += kposition[i];

            //make char arrays k and m.
            char[] k = keyword.ToCharArray();
            char[] m = message.ToCharArray();

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            int[] k_index = new int[keyword.Length];
            int[] m_index = new int[keyword.Length];

            //searching for alphabet index number of my letters
            for (int i = 0; i < keyword.Length; i++)
            {
                for (int j = 0; j < keyword.Length; j++)
                {
                    int real_i = i;
                    if (i > 25) i = (i % 25 - 1);

                    if (k[j] == alphabet[i]) k_index[j] = i;
                    if (m[j] == alphabet[i]) m_index[j] = i;
                    i = real_i;
                }
            }

            //display changed letters
            int[] result_index = new int[keyword.Length];

            for (int i = 0; i < keyword.Length; i++)
            {
                result_index[i] = k_index[i] + m_index[i];
                if (result_index[i] > 25) result_index[i] = (result_index[i] % 25 - 1);
                Console.Write(alphabet[result_index[i]]);
            }

            Console.ReadKey();
        }
    }
}