using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks the user for a year and checks if it is a leap year or not.

            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            string leapYear = year % 400 == 0 ? "is leap year" :
                year % 100 == 0 ? "is not leap year" :
                year % 4 == 0 ? "is leap year" :
                "is not leap year";
            Console.WriteLine(leapYear);

            Console.ReadKey();
        }
    }
}
