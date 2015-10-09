using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome().ToString());
        }
        static int Palindrome()
        {
            int largenum = 0;
            for(int x = 999; x >= 0; x--)
            {
                for (int y = 999; y >= 0; y--)
                {
                    if (y >= 100)
                    {
                        int ans = x * y;
                        if (isPalindrome(ans))
                        {
                            if (largenum < ans)
                            {
                                largenum = ans;
                            }
                        }
                    }
                }
            }

            return largenum;
        }
        static bool isPalindrome(int num)
        {
            bool ret = false;
            char[] sNum = num.ToString().ToCharArray();
            Array.Reverse(sNum);
            string s = new string(sNum);
            if (s == num.ToString())
            {
                ret = true;
            }
            return ret;
        }
    }
}
