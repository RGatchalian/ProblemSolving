using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> _list = new List<BigInteger>();
            BigInteger ans = 0;
            int power = 5;
            for(BigInteger x = 2; x <= 355000; x++)
            {
                BigInteger powerans = GetEachDigitPower(x,power);
                if (x == powerans)
                {
                    _list.Add(x);
                }
            }
            foreach(var bi in _list)
            {
                ans += bi;
            }
            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }
        static BigInteger GetEachDigitPower(BigInteger num,int p)
        {
            string digit = num.ToString();
            BigInteger ans = 0;
            for(int x = 0; x < digit.Length; x++)
            {
                BigInteger power = Power(BigInteger.Parse(digit[x].ToString()), p);
                ans += power;
            }
            return ans;
        }
        static BigInteger Power(BigInteger num,int power)
        {
            BigInteger ans = 1;
            for(int x=1;x<= power; x++)
            {
                ans *= num;
            }
            return ans;
        }
    }
}
