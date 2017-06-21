using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
            Console.ReadLine();
        }
        static string Fibonacci(int num)
        {
            string temp = string.Empty;
            int sum = 2;
            int firstnum = 1;
            int secondnum = 1;
            for (int x = 0; x < num; x++)
            {
                if (x <2)
                {
                    temp = "0,1,1";
                    firstnum = 1;
                    secondnum = 1;                   
                }
                else
                {
                    sum = firstnum + secondnum;
                    temp += "," + +sum;
                    firstnum = secondnum;
                    secondnum = sum;
                }

            }
            return temp;
        }
    }
}
