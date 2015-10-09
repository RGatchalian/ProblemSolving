using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPrimeFactor(600851475143).ToString());
        }
        static long LargestPrimeFactor(long num)
        {
            long largenum = 0;
            List<long> answers = new List<long>();
            long ans = num;
            long count = 1;
            do
            {
                if((num% count) == 0)
                {
                    answers.Add(count);
                    long test = 1;
                    foreach (long a in answers)
                    {
                        test *= a;
                    }
                    ans = num / test;
                }                
                count++;
            } while (ans != 1 && count>1);
            foreach(long a in answers)
            {
                if (largenum < a)
                {
                    largenum = a;
                }
            }
            return largenum;
        }
    }
}
