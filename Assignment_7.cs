using System;

namespace AssignmentSolution
{
    class Assignment_7
    {
        static bool isPrimeNumber(int num)
        {
            // do stuff here
            int flag = 0;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;
            else
                return false;
        }    
        static int inputInt(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int number = inputInt("Enter the number: ");
            if (number == 1)
                Console.WriteLine("1 is neither a prime nor a composite number");
            else
               Console.WriteLine(isPrimeNumber(number));
        }
    }
}