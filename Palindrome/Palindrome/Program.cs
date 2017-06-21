using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abba";
            Console.WriteLine("{0} - {1}", input, (IsPalindrome(input) ? "Palindrome" : "Not Palindrome"));
            Console.ReadLine();
        }
        static bool IsPalindrome(string s)
        {
            string sCopy = ReverseString( s);
            if (sCopy.ToUpper() == s.ToUpper())
            {
                return true;
            }
            return false;
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
