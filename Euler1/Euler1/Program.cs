using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumofnum());
        }
        static string sumofnum()
        {
            int sum = 0;
            for(int x = 0; x < 1000; x++)
            {
                if((x%3)==0 || (x % 5) == 0)
                {
                    sum += x;
                }
            }
            return sum.ToString();
        }
    }
}
