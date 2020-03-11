using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            int input = int.Parse(Console.ReadLine());
            int number = input;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number);
                }
                number--;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
