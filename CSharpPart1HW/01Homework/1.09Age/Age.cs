using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace _1._09Age
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input birth date YYYY-MM-DD:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int years = now.Year - date.Year;
            int months = now.Month - date.Month;
            int days = now.Day - date.Day;
            if (months < 0)
            {
                Console.WriteLine("Age: " + (years - 1) + "\nAge after 10 years: " + (years -1 + 10));
            }
            else if (months == 0 && days < 0)
            {
                Console.WriteLine("Age: " + (years - 1) + "\nAge after 10 years: " + (years - 1 + 10));
            }
            else
            {
                Console.WriteLine("Age: " + years + "\nAge after 10 years: " + (years + 10));
            }
        }
    }
}
