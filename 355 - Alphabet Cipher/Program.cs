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

            //2) divide it to two parts ( separator - space )
            //  keyword = train
            //  message = murderontheorientexpress

            //3) count message letters and extend keyword as much as needed so
            //  keyword = traintraintraintraintrai
            //  message = murderontheorientexpress

            //4) make arrays from those strings where every letter is separated.

            //5) figure out how to multiply these two letters to have the result...
            //    k[i] * m[i] = result[i]

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}