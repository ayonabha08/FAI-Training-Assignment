using System;
using System.Linq;

namespace AssignmentSolution
{
    class Assignment_9
    {
        public static string reverseByWords(string sentence)
        {
            // do stuff here
            string reversed= "";
            reversed=string.Join(" ", sentence.Split(' ').Reverse());
            return reversed;            
        }
        static string inputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string Words = inputString("Enter the sentence: ");
            Console.WriteLine(reverseByWords(Words));
        }

    }
}