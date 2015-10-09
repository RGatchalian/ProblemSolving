using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Euler37
{
    class Program
    {
        static List<BigInteger> _list = new List<BigInteger>();
        static void Main(string[] args)
        {
            int count = 0;
            BigInteger sum = 0;
            BigInteger ans = 0;
            for (BigInteger x =9; x <1000000 ; x++)
            {
                //if (count < 11)
                //{
                    if (IsPrimeNumber(x))
                    {
                        if (IsTruncatable(x))
                        {
                            Console.WriteLine(x);
                            _list.Add(x);
                        }
                    }
                //}
                //else
                //{
                //    break;
                //}
            }
            foreach (var l in _list)
            {
                ans += l;
            }
            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }
        static bool IsTruncatable(BigInteger num)
        {
            if (IsLeftTruncatable(num.ToString()))
            {
                if(IsRightTruncatable(num.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        static bool IsLeftTruncatable(string num)
        {
            bool res = false;
            for (int x = 0; x < num.Length; x++)
            {
                BigInteger newnum = BigInteger.Parse( num.Substring(x));
                if (IsPrimeNumber(newnum))
                {
                    res = true;
                }
                else
                {
                    return false;
                }
            }
            return res;
        }
        static bool IsRightTruncatable(string num)
        {
            bool res = false;
            string rev = ReverseString(num);
            for (int x = 0; x < rev.Length; x++)
            {
                BigInteger newnum = BigInteger.Parse(ReverseString( rev.Substring(x)));
                if (IsPrimeNumber(newnum))
                {
                    res = true;
                }
                else
                {
                    return false;
                }
            }
            return res;
        }
        static string ReverseString(string s)
        {
            char[] tmp = s.ToCharArray();
            Array.Reverse(tmp);
            return new string(tmp);
        }
        static bool IsPrimeNumber(BigInteger num)
        {
            if (num == 1) return false;
            for (int x = 1; x <= num; x++)
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
