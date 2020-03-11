using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的字串 :");
            string[] inputS = (Console.ReadLine()).Split(',');
            
            Array.Reverse(inputS);
            for(int i = 0; i < inputS.Length; i++)
            {
                Console.Write(inputS[i]);
                if (i == (inputS.Length - 1))
                {
                    break;
                }
                Console.Write(",");
            }
            Console.ReadLine();
        }
    }
}
