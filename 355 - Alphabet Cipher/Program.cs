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
            //Substitution chart
            //result - the result of the substrition chart
            //first- letter of my keyword
            //second- letter of the message that is being encoded
            //result = first * second

            //CHALLENGE INPUT
            // train murderontheorientexpress\

            //THINGS TO DO:
            //1) take user input
            Console.WriteLine("Sample input: keyword messagetoencode");
            Console.Write("Your input: ");

            //2) divide it to two parts ( separator - space )
            string[] input = Console.ReadLine().Trim().Split(' ');

            //3) count message letters and extend keyword as much as needed so
            //  keyword = traintraintraintraintrai
            //  message = murderontheorientexpress

            var keyword = input[0];

            Console.WriteLine(input[1].Length / input[0].Length);
            Console.WriteLine(input[1].Length % input[0].Length);

            char[] k = input[0].ToCharArray();

            for (int i = 1; i < (input[1].Length / keyword.Length); i++)
            {
                input[0] += keyword;
            }

            for (int i = 0; i < (input[1].Length % keyword.Length); i++)
            {
                input[0] += k[i];
            }

            Console.WriteLine(input[0]);

            //4) make arrays from those strings where every letter is separated.

            Console.ReadLine();

            //5) figure out how to multiply these two letters to have the result...
            //    k[i] * m[i] = result[i]
        }
    }
}