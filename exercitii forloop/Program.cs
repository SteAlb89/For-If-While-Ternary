using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercitii_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that displays all numbers from 10 to 90 to the console

            for (int i = 10; i <= 90; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
