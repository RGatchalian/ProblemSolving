using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler35
{
    class Program
    {
        static List<string> rotation = new List<string>();
        static void Main(string[] args)
        {
            long circularcount=0;
            for (long x = 2; x < 1000000; x++)
            {
                if (IsPrime(x))
                {
                    rotation.Clear();
                    //Console.WriteLine(x);
                    if (x.ToString().Length > 1)
                    {
                        GetRotation(x.ToString());
                        if (rotation.Count > 0)
                        {
                            long permcount = 0;
                            foreach (var s in rotation)
                            {
                                if (IsPrime(long.Parse(s)))
                                {
                                    permcount++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (permcount == rotation.Count)
                            {
                                Console.WriteLine("{0}-{1}",x,circularcount);
                                circularcount++;
                            }
                            else
                            {
                                Console.WriteLine("{0}", x);
                            }

                        }
                        else
                        {
                            Console.WriteLine("{0}-{1}", x, circularcount);
                            circularcount++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0}-{1}", x, circularcount);
                        circularcount++;
                    }

                }
            }
            Console.WriteLine("Answer is:" + circularcount);
            Console.ReadLine();
        }

        static bool IsPrime(long num)
        {
            for (long x = 2; x < num; x++)
            {
                if ((num % x) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void GetRotation(string s)
        {
            //1234 2341 3421 4321
            string newstring =s;
            int count = 0;
            char[] str = newstring.ToCharArray();
            while (count <= str.GetUpperBound(0))
            {
                char tmp = str[0];
                for (int y = 0; y < str.GetUpperBound(0); y++)
                {
                    str[y] = str[y + 1];
                }
                str[str.GetUpperBound(0)] = tmp;
                rotation.Add(new string(str));
                count++;

            }
        }
  

       
    }
}
