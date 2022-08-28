using System;

namespace AssignmentSolution
{
    class Assignment_2
    {
        static void ArrayInput(int[] myArray)
        {
            //Console.WriteLine("Enter the size of the array: ");
            //size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements to be entered into the array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());               
            }
        }
        static void Display(int[] myArray)
        {
            foreach (var item in myArray)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"{item} is even");
                }
                else
                {
                    Console.WriteLine($"{item} is odd");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] elements = new int[size];
            ArrayInput(elements);
            Display(elements);
            
        }
    }
}