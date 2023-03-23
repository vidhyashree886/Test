using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, rem, temp, sum = 0;
            Console.WriteLine("check if armstrong number or not");
            Console.Write("enter your number to check:");
            number = Convert.ToInt32(Console.ReadLine());

            temp = number;
            while (number > 0)

            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;

            }
            if (temp == sum)

                Console.WriteLine(temp + " is an armstrong number");
            else
                Console.WriteLine(temp + " is not an armstrong number");
            Console.ReadLine();
        }
             

                         
    }
}
