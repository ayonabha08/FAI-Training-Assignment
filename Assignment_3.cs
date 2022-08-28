using System;

namespace AssignmentSolution
{
    class Assignment_3
    {
        static bool MathCalc(double value1, double value2, string operation)
        {
            bool n = true;
            switch (operation)
            {
                case "1":
                    Console.WriteLine($"The added value is {value1 + value2}");
                    break;
                case "2":
                    Console.WriteLine($"The subtracted value is {value1 - value2}");
                    break;
                case "3":
                    Console.WriteLine($"The multiplicated value is {value1 * value2}");
                    break;
                case "4":
                    Console.WriteLine($"The divided value is {value1 / value2}");
                    break;
                case "5":
                    n = false;
                    break;
                default:
                    Console.WriteLine($"Invalid operation: "); break;

            }
            return n;
        }
        static double inputDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
        static string inputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
RETRY:      var value1 = inputDouble("Enter the first value:");
            var value2 = inputDouble("Enter the second value: ");
            var choice = inputString("Enter your choice as 1.+, 2.-, 3.X, 4./, 5. Exit: ");
            if (MathCalc(value1, value2, choice))
            {
                goto RETRY;
            }
        }
    }
}