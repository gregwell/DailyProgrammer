using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_zone
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Integer Size.");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("That was invalid. Enter a valid Grid Size.");
            }

            // use gridSize here
            Console.ReadKey();
        }
    }
}
