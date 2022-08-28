using System;

namespace AssignmentSolution
{
    class Assignment_4
    {
        static void ArrayInput(int[] myArray)
        {
            Console.WriteLine("Enter the elements to be entered into the array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
        }
        
        static void SumOddEven(int[] myArray)
        {
            int sumOdd=0, sumEven=0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                    sumOdd += myArray[i];
                else
                    sumEven += myArray[i];
            }
            Console.WriteLine($"Sum of odd numbers in the array is {sumOdd}");
            Console.WriteLine($"Sum of even numbers in the array is {sumEven}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] elements = new int[size];
            ArrayInput(elements);
            SumOddEven(elements);
        }
    }
}