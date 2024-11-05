using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 2.1";

            Console.WriteLine("This program checks if two number are equal, please enter two numebrs and press enter after each one");

            double numOne = Convert.ToDouble(Console.ReadLine());
            double numTwo = Convert.ToDouble(Console.ReadLine());

            if (numOne == numTwo)
            {
                Console.WriteLine("These numbers are equal!");

            }
            else
            {
                Console.WriteLine("These numebrs are not equal");
            }
            Console.Read();















        }



    }
}
