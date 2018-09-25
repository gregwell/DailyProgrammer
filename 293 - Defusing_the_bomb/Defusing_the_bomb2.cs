using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace testspace
{
    internal class Testingzone
    {
        private static void Main(string[] args)
        {
            StreamReader file = new StreamReader("test.txt");
            string thisWireLine;
            int thisWire, prevWire = ConvertLine(file.ReadLine());
            using (file)
            {
                while ((thisWireLine = file.ReadLine()) != null)
                {
                    thisWire = ConvertLine(thisWireLine);
                    if (!NextStep(prevWire, thisWire))
                    {
                        Console.WriteLine("Boom");
                        return;
                    }
                    prevWire = thisWire;
                }
            }
            Console.WriteLine("Bomb defused");
        }

        private static bool NextStep(int actual, int next)
        {
            if (actual == 1) return next != 1 && next != 3;
            else if (actual == 2) return next == 5;
            else if (actual == 3) return next != 1 && next != 4 && next != 5;
            else if (actual == 4) return next == 2 || next == 3;
            else if (actual == 5) return next == 1 || next == 4;
            else if (actual == 6) return next == 2 || next == 3;

            System.Diagnostics.Debug.Assert(false, "Error checking sequence.");
            return false;
        }

        private static int ConvertLine(string wireColor)
        {
            if (string.Equals(wireColor, "white")) return 1;
            else if (string.Equals(wireColor, "red")) return 2;
            else if (string.Equals(wireColor, "black")) return 3;
            else if (string.Equals(wireColor, "orange")) return 4;
            else if (string.Equals(wireColor, "green")) return 5;
            else if (string.Equals(wireColor, "purple")) return 6;

            System.Diagnostics.Debug.Assert(false, "Error converting line.");
            return 0;
        }
    }
}