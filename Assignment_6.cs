using System;

namespace AssignmentSolution
{
    class Assignment_6
    {
        const int MAX_VALID_YR = 9999;
        const int MIN_VALID_YR = 1800;
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }
        static bool isValidDate(int year, int month, int date)
        {
            if (year > MAX_VALID_YR || year < MIN_VALID_YR)
                return false;
            if (month < 1 || month > 12)
                return false;
            if (date < 1 || date > 31)
                return false;
            if (month == 2)
            {
                if (isLeap(year))
                    return (date <= 29);
                else
                    return (date <= 28);
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return (date <= 30);
            return true;
        }

        static int inputInt(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int Year=inputInt("Enter the year: ");
            int Month = inputInt("Enter the month: ");
            int Date = inputInt("Enter the date: ");
            if(isValidDate(Year, Month, Date))
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Invalid date");
            }
        }
    }
}