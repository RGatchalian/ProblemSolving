using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
           int ans=GetPrimaryNumbers(10001);
            Console.WriteLine("Answer is:" + ans);
        }

        static int GetPrimaryNumbers(int level)
        {
            int num = 1;
            int count = 0;
            do
            {
                num++;
                if (IsPrimaryNumber(num))
                {
                    count++;
                }
            } while (count != level);
            return num;
        }
        static bool IsPrimaryNumber(int num)
        {
            for(int x = 1; x <= num; x++)
            {
                if(x!=1 && x != num)
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
