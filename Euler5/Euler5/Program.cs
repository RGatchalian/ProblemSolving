using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDivisible();
        }
        static long AllDivisible()
        {
            long num= 1;
            
            bool found = false;
            do
            {
                int realcount = 0;
                num++;
                //Console.Write("num:" + num + ",");
                for(int x = 1; x <= 20; x++)
                {
                    if ((num % x)!=0)
                    {
                        found = false;
                        x = 21;
                    }
                    else
                    {
                        found = true;
                        realcount++;
                    }
                }
                if(found==true && realcount == 20)
                {
                    found = true;
                }

            } while (found == false);
            Console.WriteLine(num.ToString());
            Console.ReadLine();
            return 0;
        }
    }
}
