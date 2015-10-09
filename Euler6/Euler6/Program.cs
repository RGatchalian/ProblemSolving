using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            long level = 100;
            long sumofthesquare=SumOfTheSquare(level);
            long squareofthesum = Square(SquareOfTheSum(level));
            long diffans = squareofthesum-sumofthesquare  ;
            Console.WriteLine("Answer is:" + diffans);
        }

        static long SquareOfTheSum(long level)
        {
            long res = 0;
            for (int x = 1; x <= level; x++)
            {
                res += x;
            }
            return res;
        }
        static long SumOfTheSquare(long level)
        {
            long res = 0;
            for(int x=1; x<= level; x++)
            {
                res += Square(x);
            }
            return res;
        }
        static long Square(long num)
        {
            return num * num;
        }
    }
}
