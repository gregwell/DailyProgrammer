using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace clock
{
    internal class RedditClock
    {
        public void ShowTime()
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("\n");

                string[] hours = new string[24] { "twelve", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
                    "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" };

                string[] tens = new string[6] { "oh'", "", "twenty", "thirty", "fourty", "fifty" };

                string[] ones = new string[20] { "clock", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
                    "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };

                DateTime dt = DateTime.Now;

                int currentHour = dt.Hour;
                int currentMinutes = dt.Minute;
                int firstTens;
                int secondTens;
                string currentOnes;
                string currentTens;
                string suffix;

                if (currentHour < 12)
                {
                    suffix = "AM";
                }
                else
                {
                    suffix = "PM";
                }

                if (currentMinutes < 10)
                {
                    Console.WriteLine("It's" + " " + hours[currentHour] + " oh " + ones[currentMinutes] + " " + suffix);
                }
                else
                {
                    currentTens = currentMinutes.ToString().Substring(0, 1);
                    firstTens = int.Parse(currentTens);
                    currentOnes = currentMinutes.ToString().Substring(1, 1);
                    secondTens = int.Parse(currentOnes);

                    if ((currentMinutes >= 11) && (currentMinutes < 20))
                    {
                        Console.WriteLine("It's" + " " + hours[currentHour] + " " + ones[currentMinutes] + " " + suffix);
                    }
                    else
                    {
                        if (((tens[firstTens] == "twenty") || (tens[firstTens] == "thirty") || (tens[firstTens] == "fourty") || (tens[firstTens] == "fifty")) && (ones[secondTens] == "clock"))
                        {
                            Console.WriteLine("It's" + " " + hours[currentHour] + " " + tens[firstTens].ToUpper() + " " + suffix);
                        }
                        else
                        {
                            Console.WriteLine("It's" + " " + hours[currentHour] + " " + tens[firstTens].ToUpper() + " " + ones[secondTens] + " " + suffix);
                        }
                    }
                }

                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void Main(string[] args)
        {
            RedditClock rC = new RedditClock();
            ThreadStart TS = new ThreadStart(rC.ShowTime);
            Thread t = new Thread(TS);
            t.Start();
            Console.ReadLine();
        }
    }
}