using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler36
{
    class Program
    {
        static void Main(string[] args)
        {
            long ans = 0;
            for (int x = 0; x < 1000000; x++)
            {
                bool base10 = IsPalindrome(x.ToString());
                string bin = DecToBin(x);
                bool base2 = IsPalindrome(bin);
                if (base10 == true &&  base2==true)
                {
                    Console.WriteLine("BASE10:{0},BASE2:{1}",x,bin);
                    ans += x;
                }
            }
            Console.WriteLine("Answer is:" + ans);
            Console.ReadLine();
        }
        static bool IsPalindrome(string s)
        {
            char[] chrarr = s.ToCharArray();
            Array.Reverse(chrarr);
            string newstring = new string(chrarr);
            if(newstring==s)
            {
                return true;
            }
            return false;
        }
        static string DecToBin(long num)
        {
            string bin = "";
            long ans = num;

            while (ans > 0)
            {
                long onezero = ans % 2;
                ans /= 2;
                bin += onezero.ToString();
            }
            return bin;
        }
    }
}
