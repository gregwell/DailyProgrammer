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

            //figure out how to multiply these two letters to have the result...
            //    k[i] * m[i] = result[i]

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            // input[0] = c
            // input[0] = d
            // so input[0] ==alphabet[2]
            // so input[1] == alphabet[3]
            //so result[0] = 2+3

            //handle also cases when the count is bigger than alphabet, then you have to reset index

            //alphabet[6] to jest
        }
    }
}