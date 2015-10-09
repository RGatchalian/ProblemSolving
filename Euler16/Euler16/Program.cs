using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Answer is" + GetToThePowerSum(2,1000).ToString());
        }
        static long GetToThePowerSum(long num,long power)
        {
            BigInteger powerans = 1;
            long ans = 0;
            for(int x = 1; x <= power; x++)
            {
                powerans *= num;
            }
            string poweransstring = powerans.ToString();
            for(int x = 0; x < poweransstring.Length; x++)
            {
                ans += long.Parse(poweransstring[x].ToString());
            }         
            return ans;
        }
       
    }
}
