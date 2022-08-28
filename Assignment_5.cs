using System;

namespace AssignmentSolution
{
    class Assignment_5
    {
        static double CalculateInterest(double principle, double term, double interestRate)
        {
            double interest = (principle * term * interestRate) / 100;
            return interest;
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
            var Principle = inputDouble("Enter the principle amount: ");
            var Term = inputDouble("Enter the tenure of the loan: ");
            var InterestRate = inputDouble("Enter the interest rate: ");
            Console.WriteLine($"The Interest Amount is {CalculateInterest(Principle, Term, InterestRate)}");
        }
    }
}