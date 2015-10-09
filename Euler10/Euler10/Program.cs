using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler10
{
    class Program
    {
        static List<long> _primenumbers = new List<long>();
        static void Main(string[] args)
        {
            long ans=SumOfAllPrimeNumberByValue(2000000);
            Console.WriteLine("Answer is:{0}",ans);
            Console.ReadLine();
        }
        static long SumOfAllPrimeNumberByValue(long limitvalue)
        {
            long ans = 0;
            for(long x = 2; x < limitvalue; x++)
            {
                Console.WriteLine("Num:{0}",x);
                if (IsPrimeNumber(x))
                {
                    _primenumbers.Add(x);
                }
            }
            ans = GetSumFromList();

            return ans;
        }
        static long GetSumFromList()
        {
            long tmpans = 0;
            foreach(var n in _primenumbers)
            {
                tmpans += n;
            }
            return tmpans;
        }
        static bool IsPrimeNumber(long num)
        {
            for (long x = 1; x <= num; x++)
            {
                if (x != 1 && x != num)
                {
                    if ((num % x) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
