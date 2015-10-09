using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 4000000;
            Console.WriteLine("Starting Fibo");
            string fibans = Fibonacci(level);
            Console.WriteLine(fibans);
            //Console.WriteLine(sumeven(fibans).ToString());
        }

        static string Fibonacci(int level)
        {
            string output = "";
            int num1 = 0;
            int num2 = 0;
            for (int x = 0; x < level; x++)
            {
                if(x==0)
                {
                    num1 = 1;
                    output+="0";
                }
                else
                {
                    int ans= num1 + num2;
                    num2 = num1;
                    num1 = ans;
                    output += ans;
                    if (ans>=4000000)
                    {
                        return sumeven(output);
                    }
                }
                output += ",";
                Console.WriteLine(output);
                
            }
            return output;
        }
        static string sumeven(string num)
        {
            string[] snum = num.Split(',');
            int total = 0;
            foreach(string s in snum)
            {
                int n = int.Parse(s);
                if ((n % 2) == 0)
                {
                    total += n;
                }
            }
            return total.ToString();
        }
    }
}
