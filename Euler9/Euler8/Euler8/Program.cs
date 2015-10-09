using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler8
{
    class Program
    {
        static List<string> _digits = new List<string>();
        static List<string> _debugdigits = new List<string>();
        static void Main(string[] args)
        {
            string digitsStr = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            GetDigits(digitsStr,13);
            Console.WriteLine("Answer is:" + ProcessDigits().ToString());
        }
        static long ProcessDigits()
        {
            long tmpnum = 1;
            long largestnum = 0;
            string largestprod = "";
            string debugdigits = "";
            foreach (string s in _digits)
            {
                for (int x = 0; x < s.Length; x++)
                {
                    tmpnum *= long.Parse(s[x].ToString());
                    debugdigits += s[x].ToString() + ",";
                }
                Console.WriteLine(debugdigits);
                if (largestnum < tmpnum)
                {
                    largestnum = tmpnum;
                    largestprod = debugdigits;
                }
                debugdigits = "";
                tmpnum = 1;
            }
            Console.WriteLine("LARGEST PROD:" + largestprod);
            return largestnum;
        }
        static void GetDigits(string s,int num)
        {
            int curcount = 0;
            do
            {
                string tmpstr = "";
                if ((curcount+num) <= s.Length)
                {
                    tmpstr = s.Substring(curcount, num);
                }
                else
                {
                    tmpstr = s.Substring(curcount);
                }
                //Console.WriteLine(tmpstr.Replace("0", ""));
                _digits.Add(tmpstr);
                curcount += 1;
            } while (curcount < s.Length);
        }
    }
}
