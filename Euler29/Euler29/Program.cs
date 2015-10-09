using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> _terms = new List<BigInteger>();
            for(int x = 2; x <= 100; x++)
            {
                for (int y = 2; y <= 100; y++)
                {
                    BigInteger ans = Power(x, y);
                    Console.WriteLine("x:{0},y:{1}",x,y);
                    if (_terms.IndexOf(ans) < 0)
                    {
                        _terms.Add(ans);
                    }
                }
            }
            Console.WriteLine("Answer is:" + _terms.Count);
            Console.ReadLine();
        }
        static BigInteger Power(BigInteger num, BigInteger power)
        {
            BigInteger ans = 1;
            for(int x = 1; x <= power; x++)
            {
                ans *= num;
            }
            return ans;
        }
    }
}
