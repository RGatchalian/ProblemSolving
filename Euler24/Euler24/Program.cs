using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Euler24
{
    class Program
    {
        static List<string> permutation = new List<string>();
        static int count = 0;
        static void Main(string[] args)
        {
            string digits = "0123456789";
            int count = 0;
            string newstring = digits;
            var lexicographic = from p in permutation
                                orderby p
                                select p;
            int pcount = 0;
            string millionth = "";
            GetPermutation("",digits);
            using (StreamWriter sw = new StreamWriter(System.Windows.Forms.Application.StartupPath + "\\dataoutput.txt"))
            {
                foreach (var p in lexicographic)
                {
                    pcount++;
                    if (pcount == 1000000)
                    {
                        millionth = p;
                        sw.WriteLine("Millionth:" + p);

                    }
                    else{
                    
                        sw.WriteLine(p);
                    }
                }
            }
            Console.WriteLine("Count:" + permutation.Count);
            Console.WriteLine("Answer is:" + millionth);
            Console.ReadLine();
        }
        static void GetPermutation(string chr, string s)
        {
            for (int x = 0; x < s.Length; x++)
            {
                string statchar="";
                statchar = chr +  s[x].ToString();
                string toperm = RemoveStaticCharToString(statchar,s);
                for (int y = 0; y < toperm.Length; y++)
                {
                    string newstring = statchar + Swap(y, y + 1,toperm);
                    if (permutation.IndexOf(newstring) < 0)
                    {
                        Console.WriteLine(newstring + "-" +permutation.Count);
                        permutation.Add(newstring);
                        GetPermutation(statchar, toperm);
                    }
                }
            }
        }

        static string RemoveStaticCharToString(string schr,string origstr)
        {
            string newstr = origstr;
            for (int x = 0; x < schr.Length; x++)
            {
                newstr = newstr.Replace(schr[x].ToString(), "");
            }
            return newstr;
        }
       
        static string Swap(int frompos,int topos,string s)
        {
            if (topos == s.Length) return s;
            char[] list = s.ToCharArray();
            char tmp = list[frompos];
            list[frompos] = list[topos];
            list[topos] = tmp;
            return new string(list);
        }

    }
}
