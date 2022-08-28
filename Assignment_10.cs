using System;

namespace AssignmentSolution
{
    class Assignment_10
    {
        static string[] one = { "", "one ", "two ", "three ", "four ",
                            "five ", "six ", "seven ", "eight ",
                            "nine ", "ten ", "eleven ", "twelve ",
                            "thirteen ", "fourteen ", "fifteen ",
                            "sixteen ", "seventeen ", "eighteen ",
                            "nineteen " };
        static string[] ten = { "", "", "twenty ", "thirty ", "forty ",
                            "fifty ", "sixty ", "seventy ", "eighty ",
                            "ninety " };

        public static string inWords(int num)
        {
            // do stuff here
            // stores word representation of
            // given number n
            string output = "";

            // handles digits at ten millions and
            // hundred millions places (if any)
            output += numToWords((int)(num / 10000000),
                               "crore ");

            // handles digits at hundred thousands
            // and one millions places (if any)
            output += numToWords((int)((num / 100000) % 100),
                               "lakh ");

            // handles digits at thousands and tens
            // thousands places (if any)
            output += numToWords((int)((num / 1000) % 100),
                               "thousand ");

            // handles digit at hundreds places (if any)
            output += numToWords((int)((num / 100) % 10),
                               "hundred ");

            
            // handles digits at ones and tens
            // places (if any)
            output += numToWords((int)(num % 100), "");

            return output;

        }
        
        static string numToWords(int n, string s)
        {
            string str = "";
            // if n is more than 19, divide it
            if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
            {
                str += one[n];
            }

            // if n is non-zero
            if (n != 0)
            {
                str += s;
            }

            return str;
        }
        static int inputInt(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int number = inputInt("Enter the number: ");
            Console.WriteLine(inWords(number));
        }
    }
}