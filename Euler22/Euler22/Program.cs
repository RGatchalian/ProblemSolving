using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
namespace Euler22
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = System.Windows.Forms.Application.StartupPath + "\\name.txt";
            BigInteger total = 0;
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadToEnd();
                string[] arrname = line.Replace("\"", "").Split(',');
                var names = from n in arrname
                            orderby n ascending
                            select n;
                long position = 1;
                long namevalue = 0;

                foreach (var n in names)
                {
                    namevalue = NameValue(n);
                    total += (position * namevalue);
                    position++;
                }
            }

            Console.WriteLine("Answer is: " + total);
            Console.ReadLine();
        }
        static long NameValue(string name)
        {
            long ans = 0;
            for(int x = 0; x < name.Length; x++)
            {
                ans += LetterValue(name[x]);
            }
            return ans;
        }
        static long LetterValue(char c)
        {
            char[] Alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for(int x = 0; x <= Alphabet.GetUpperBound(0); x++)
            {
                if (Alphabet[x] == c)
                {
                    return x + 1;
                }
            }
            return 0;
        }
    }
}
