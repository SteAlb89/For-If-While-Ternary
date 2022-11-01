using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumbers55_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that displays all numbers from 55 to 99 to the console
            int number = 54;

            while (number < 99)
            {
                number++;
                Console.WriteLine(number);

            }

            Console.ReadKey();
        }
    }
}
