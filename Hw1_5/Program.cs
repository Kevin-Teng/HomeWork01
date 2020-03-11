using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個中華民國年份，判斷是否為閏年 : ");
            int input = int.Parse(Console.ReadLine());
            int i = input + 1911;

            if (i % 4 == 0)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {
                        Console.WriteLine("${input}年為潤年");
                    }
                    else
                    {
                        Console.WriteLine($"{input}年為平年");
                    }
                }
                else 
                {
                    Console.WriteLine($"{input}年為潤年");
                }
            }
            else 
            {
                Console.WriteLine($"{input}年為平年");
            }Console.ReadLine();

        }
    }
}
