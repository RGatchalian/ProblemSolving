using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> _list = new List<long>();
            long ans = 0;
            for (long x = 3; x < 100000; x++)
            {
                long totalfactorial=GetFactorialPerDigit(x);
                if (x == totalfactorial)
                {
                    _list.Add(x);
                }
            }
            foreach (long l in _list)
            {
                ans += l;
            }
            Console.WriteLine(ans);
            Console.ReadLine();
        }
        static long GetFactorialPerDigit(long num)
        {
            long ans = 0;
            string snum=num.ToString();
            for (int x = 0; x < snum.ToString().Length; x++)
            {

                ans += Factorial(long.Parse(snum[x].ToString()));
            }
            return ans;
        }
        static long Factorial(long num)
        {
            long ans = 1;

            for (long x = num; x >= 1; x--)
            {
                ans *= x;
            }
            return ans;
        }
    }
}
