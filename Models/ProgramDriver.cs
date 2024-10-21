using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_b_2024_10_21_a_switch.Models
{
    public static class ProgramDriver
    {
        public static void Run()
        {
            Console.WriteLine("Running...");
        }

        public static void SwitchStatementDemo()
        {
            // $ means interpolate the variables within a string which are inside {}
            Console.WriteLine($"SwitchStatementDemo"); // makes sure constants is public with public constants
            int number = 2;
            // switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("Switch: One");
                    break;
                case 2:
                    Console.WriteLine("Switch: Two");
                    break;
                case 3:
                    Console.WriteLine("Switch: Three");
                    break;

                case 4:
                    Console.WriteLine("Switch: Four");
                    break;
                default:
                    Console.WriteLine($"{number} Not handled");
                    break;
            }
        }

        public static void SwitchExpressionDemo()
        {
            Console.WriteLine("Switch Expression Demo");

            int number = 5;

            string result = number switch
            {

                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                _ => "Not a valid number"

            }; // unlike switch statement, expression needs a ; at end

            Console.WriteLine($"Switch Expression Result: {result}");
        }


    }
}
