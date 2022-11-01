using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthSeason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prompts the user for a calendar month and displays the corresponding season.

            Console.WriteLine("Enter a month:");
            string month = Console.ReadLine();

            if (month == "December" || month == "January" || month == "February")
            {
                Console.WriteLine("The season is winter");
            }
            if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("The season is spring");
            }

            if (month == "Juni" || month == "July" || month == "August")
            {
                Console.WriteLine("The season is summer");
            }

            if (month == "September" || month == "October" || month == "November")
            {
                Console.WriteLine("The season is autumn");
            }

            Console.ReadKey();
        }
    }
}
