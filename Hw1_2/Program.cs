using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的整數數字字串 :");
            string input = Console.ReadLine();
            string[] inputS = input.Split(',');
            int oddCount = 0, evenCount = 0;

            foreach (string i in inputS)
            {
                if (int.Parse(i) % 2 == 1)
                {
                    oddCount++;
                }
                else
                {
                    evenCount++;
                }
            }
            
            int[] oddArray = new int[oddCount];
            int[] evenArray = new int[evenCount];
            oddCount = 0;
            evenCount = 0;

            foreach (string i in inputS)
            {
                int num = int.Parse(i);
                if (num % 2 == 1)
                {
                    oddArray[oddCount] = int.Parse(i);
                    oddCount++;
                }
                else
                {
                    evenArray[evenCount] = int.Parse(i);
                    evenCount++;
                }
            }

            Array.Sort(oddArray);
            Array.Sort(evenArray);
            string oddStr = string.Join(",",oddArray);
            string evenStr = string.Join(",", evenArray);
            Console.WriteLine($"奇數 : {oddStr}");
            Console.WriteLine($"偶數 : {evenStr}");

            //Console.Write("奇數 :　");
            //foreach (var i in inputS)
            //{
            //    if (int.Parse(i) % 2 == 1)
            //    {
            //        Console.Write($"{i},");
            //    }
            //}

            //Console.Write("偶數 : ");
            //foreach (var i in inputS)
            //{
            //    if (int.Parse(i) % 2 == 0)
            //    {
            //        Console.Write($"{i},");
            //    }
            //}

            Console.ReadLine();
        }
    }
}