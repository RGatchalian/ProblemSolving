using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler48
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger ans = 0;

            for (int x = 1; x <= 1000; x++)
            {
                ans += Power(x, x);
            }
            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }
        static BigInteger Power(int num,int power)
        {
            BigInteger ans = 1;
            for (int x = 1; x <= power; x++)
            {
                ans *= num;
            }
            return ans;
        }
    }
}
