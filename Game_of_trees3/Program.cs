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
            GameOfThrees(100);
            Console.ReadKey();
        }

        public static void GameOfThrees(int current)
        {
            int shift, mod;

            do
            {
                shift = (mod = current % 3) == 1 ? -1 : mod == 2 ? 1 : 0;
                Console.WriteLine("{0} {1}", current, current != 1 ? shift.ToString() : string.Empty);
                current = (current + shift) / 3;
            } while (current >= 1);
        }
    }
}
