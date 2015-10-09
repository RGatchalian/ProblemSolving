using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler21
{
    class Program
    {
        static void Main(string[] args)
        {
            long ans = 0;
            int level = 10000;
            List<long> _amicablenumbers = new List<long>();
            for (int x = 1; x < level; x++)
            {
                long a = ProcessAmicable(x);
                //Console.WriteLine("#1:" + a);
                long b = ProcessAmicable(a);
                //Console.WriteLine("#2:" + b);
                if (x == b && a != b)
                {
                    Console.WriteLine("N:" + x);
                    Console.WriteLine("Ammicable");
                    ans += a;
                }

            }

            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }

        static long ProcessAmicable(long num)
        {
            List<int> _tmp = GetDivisors(num);
            long ans = 0;
            foreach(int i in _tmp)
            {
                ans += i;
            }
            return ans;
        }

        static List<int> GetDivisors(long num)
        {
            List<int> _tmp = new List<int>();
            if (num == 1)
            {
                _tmp.Add(1);
            }
            else
            {
                for (int x = 1; x < num; x++)
                {
                    if ((num % x) == 0)
                    {
                        _tmp.Add(x);
                    }
                }

            }
            return _tmp;
        }

    }
}
