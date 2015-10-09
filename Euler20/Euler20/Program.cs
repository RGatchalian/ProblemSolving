using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler20
{
    class Program
    {
        static void Main(string[] args)
        {
            string factorial = Factorial(100).ToString();
            long total = 0;
            
            for(int x = 0; x < factorial.Length; x++)
            {
                total += long.Parse(factorial[x].ToString());
            } 
            Console.WriteLine("Answer is:" + total);
        }
        static BigInteger Factorial(long num)
        {
            BigInteger ans = 1;
            for(long x=1;x<= num; x++)
            {
                ans *= x;
            }
            return ans;
        }
    }
}
