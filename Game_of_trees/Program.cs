using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (number != 1)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number + " 0");
                    number /= 3;
                }
                else if((number+1) % 3 == 0)
                {
                    Console.WriteLine("{0} (+1)", number);
                    number += 1;
                    number /= 3;
                }
                else
                {
                    Console.WriteLine("{0} (-1)", number);
                    number -= 1;
                    number /= 3;
                }
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
