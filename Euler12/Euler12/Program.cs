using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            int divcount=0;
            long count = 1;
            long generatedtrianglenum = 0;
            do
            {
                generatedtrianglenum = MakeTriangleNumbers(count);
                count++;
                divcount = GetDivisorCount(generatedtrianglenum);
                Console.Write("{0},",divcount.ToString());
            } while (divcount <= 500);
            Console.WriteLine("Answer is:" + generatedtrianglenum);
            Console.ReadLine();
        }
        static long MakeTriangleNumbers(long num)
        {
            long ans = 0;
            for (int x = 1; x <= num; x++)
            {
                ans += x;
            }
            return ans;
        }
        static int GetDivisorCount(long num)
        {
            int res = 0;
            List<long> _nums = new List<long>();
            _nums.Clear();
            for (int x = 1; x <= num; x++)
            {
                if ((num % x) == 0)
                {
                    _nums.Add(x);
                }
            }
            return _nums.Count;
        }
    }
}
