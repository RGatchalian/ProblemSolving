using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler25
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans=Fibonacci();
            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }

        static int Fibonacci()
        {
            BigInteger num1 = 0;
            BigInteger num2 = 0;
            BigInteger ans = 0;
            string digit = "";
            int seriescount = 0;
            do
            {
                if (digit.Length == 0)
                {
                    num1 = 1;
                    digit = num1.ToString();
                }
                else
                {
                    ans = num1 + num2;
                    num2 = num1;
                    num1 = ans;
                    digit = ans.ToString();
                    //Console.WriteLine(ans);
                }

                seriescount++;

            } while (digit.Length != 1000);
            Console.WriteLine(digit);
            return seriescount;
        }
    }
}
