using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一整數數字 : ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            //input = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("請輸入一非0數字!");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine($"{input}為奇數!");
            }
            else
            {
                Console.WriteLine($"{input}為偶數!");
            }

            //if (input % 2 == 0)
            //{
            //    Console.WriteLine($"{input} is Even.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is Odd.");
            //}

            Console.ReadLine();
        }
    }
}
