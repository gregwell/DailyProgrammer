using System;

namespace Talking_clock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GenerateOutput(GetValidInput());
        }

        private static int[] GetValidInput()
        {
            int[] inputIntegers = new int[2];
            bool inputInvalid = true;
            while (inputInvalid)
            {
                Console.WriteLine("Input hh:mm or exit.");
                string[] input = Console.ReadLine().Trim().Split(':');
                if (input[0].ToLower().Equals("exit"))
                {
                    /// Exit method.
                }
                else if (input.Length == 2)
                {
                    // Fills int array.
                    inputIntegers[0] = Convert.ToInt32(input[0]);
                    inputIntegers[1] = Convert.ToInt32(input[1]);
                    // If input numbers are valid, while loop exits.
                    inputInvalid = !ValidateInput(inputIntegers);
                }
            }

            return inputIntegers;
        }

        private static bool ValidateInput(int[] input)
        {
            return (input[0] >= 0 && input[0] <= 23 && input[1] >= 0 && input[1] <= 59);
        }

        private static void GenerateOutput(int[] input)
        {
            // handles am/pm situation
            string amPm = GenerateAmPm(input[0]);
            // Continues with output generation.
            string output = String.Format("It's {0}{1}{2}", GenerateHoursString(input[0]), GenerateMinutesString(input[1]), amPm);
            Console.WriteLine(output);
        }

        private static string GenerateAmPm(int hour)
        {
            string ampm = "";
            if (hour >= 12)
            {
                ampm = "pm";
            }
            else
            {
                ampm = "am";
            }

            return ampm;
        }

        private static string GenerateHoursString(int hour)
        {
            string hourWord = "you broke hours ";
            // handles pm clause
            if (hour >= 13)
            {
                hour -= 12;
            }

            // onto our generation

            switch (hour)
            {
                case 0: hourWord = "twelve "; break;
                case 1: hourWord = "one "; break;
                case 2: hourWord = "two "; break;
                case 3: hourWord = "three "; break;
                case 4: hourWord = "four "; break;
                case 5: hourWord = "five "; break;
                case 6: hourWord = "six "; break;
                case 7: hourWord = "seven "; break;
                case 8: hourWord = "eight "; break;
                case 9: hourWord = "nine "; break;
                case 10: hourWord = "ten "; break;
                case 11: hourWord = "eleven "; break;
                case 12: hourWord = "twelve "; break;
                default:
                    break;
            }

            return hourWord;
        }

        private static string GenerateMinutesString(int minute)
        {
            string minuteWord = "";

            if (minute == 0)
            {
            }
            else if (minute < 10)
            {
                minuteWord = "oh " + NumberAsWord(minute);
            }
            else if (minute < 20)
            {
                minuteWord = NumberAsWord(minute);
            }
            else if (minute < 30)
            {
                minuteWord = "twenty " + NumberAsWord(minute - 20);
            }
            else if (minute < 40)
            {
                minuteWord = "thirty " + NumberAsWord(minute - 30);
            }
            else if (minute < 50)
            {
                minuteWord = "fourty " + NumberAsWord(minute - 40);
            }
            else if (minute < 60)
            {
                minuteWord = "fifty " + NumberAsWord(minute - 50);
            }

            return minuteWord;
        }

        private static string NumberAsWord(int input)
        {
            switch (input)
            {
                case 0: return "";
                case 1: return "one ";
                case 2: return "two ";
                case 3: return "three ";
                case 4: return "four ";
                case 5: return "five ";
                case 6: return "six ";
                case 7: return "seven ";
                case 8: return "eight ";
                case 9: return "nine ";
                case 10: return "ten ";
                case 11: return "eleven ";
                case 12: return "twelve ";
                case 13: return "thirteen ";
                case 14: return "fourteen ";
                case 15: return "fifteen ";
                case 16: return "sixteen ";
                case 17: return "seventeen ";
                case 18: return "eighteen ";
                case 19: return "nineteen ";
                default:
                    return "outofboundsnumberAsWord";
            }
        }
    }
}