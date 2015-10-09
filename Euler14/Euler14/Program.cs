using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler14
{
    class Program
    {
        static void Main(string[] args)
        {
            long startingnumber = CollatzSequence(1000000);
            Console.WriteLine("Collatz is:" + startingnumber);
        }
        static long CollatzSequence(long level)
        {
            long longestseqcount = 0;
            long tmpseqcount = 0;
            long startingnumber = 0;
            for(int x=1;x<= level; x++)
            {
                tmpseqcount = GetSequence(x);
                if (longestseqcount < tmpseqcount)
                {
                    longestseqcount = tmpseqcount;
                    startingnumber = x;
                }
            }

            return startingnumber;
        }
        static long GetSequence(long num)
        {
            List<long> _sequence = new List<long>();
            long collatz = num;
            _sequence.Add(collatz);
            do
            {
                if ((collatz % 2) == 0)
                {
                    collatz /= 2;
                }
                else
                {
                    collatz = (3 * collatz) + 1;
                }
                _sequence.Add(collatz);
            } while (collatz != 1);

            return _sequence.Count;
        }
    }
}
