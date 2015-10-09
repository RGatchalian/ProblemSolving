using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler17
{
    class Program
    {
        static List<string> _numbers = new List<string>();
        static void Main(string[] args)
        {
            for (int x = 1; x <= 1000; x++)
            {
                string numstr = ParseNumber(x);
                _numbers.Add(numstr);
            }
            long ans = 0;
            foreach (var s in _numbers)
            {
                ans += s.Length;
            }
            Console.WriteLine("Answer is" + ans);

            Console.WriteLine("Answer is:" + ParseNumber(111));
            Console.ReadLine();
        }
        static string ParseNumber(long num)
        {
            string ones = "";
            string tens = "";
            string hundreds = "";
            string thousands = "";

            char[] arr = num.ToString().ToCharArray();
            Array.Reverse(arr);
            string revstr = new string(arr);
            for(int x = 0; x < revstr.Length; x++)
            {
                switch (x)
                {
                    case 0:
                        if (revstr[x].ToString() != "0")
                        {
                            string[] onesarr = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
                            ones = onesarr[int.Parse(revstr[x].ToString()) - 1];
                        }
                        break;
                    case 1:
                        if (revstr[x].ToString() != "0")
                        {
                            if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "1")
                            {
                                tens= "eleven";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "2")
                            {
                                tens = "twelve";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "3")
                            {
                                tens = "thirteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "4")
                            {
                                tens = "fourteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "5")
                            {
                                tens = "fifteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "6")
                            {
                                tens = "sixteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "7")
                            {
                                tens = "seventeen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "8")
                            {
                                tens = "eighteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1" && revstr[x - 1].ToString() == "9")
                            {
                                tens = "nineteen";
                                ones = "";
                            }
                            else if (revstr[x].ToString() == "1")
                            {
                                tens = "ten";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length==2)
                                {
                                    return tens;
                                }

                            }
                            else if (revstr[x].ToString() == "2")
                            {
                                tens = "twenty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }

                            }
                            else if (revstr[x].ToString() == "3")
                            {
                                tens = "thirty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "4")
                            {
                                tens = "forty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "5")
                            {
                                tens = "fifty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "6")
                            {
                                tens = "sixty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "7")
                            {
                                tens = "seventy";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "8")
                            {
                                tens = "eighty";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                            else if (revstr[x].ToString() == "9")
                            {
                                tens = "ninety";
                                if (revstr[x - 1].ToString() == "0" && revstr.Length == 2)
                                {
                                    return tens;
                                }
                            }
                        }

                        break;
                    case 2:
                        if (revstr[x].ToString() != "0")
                        {
                            string[] hundarr = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
                            hundreds = hundarr[int.Parse(revstr[x].ToString()) - 1];
                            if (revstr[x - 1].ToString() == "0" && revstr[x - 2].ToString() == "0")
                            {
                                return hundreds + "hundred";
                            }
                            else
                            {
                                hundreds += "hundredand";
                            }

                        }
                        break;
                    case 3:
                        if(revstr[x].ToString() != "0")
                        {
                            string[] thouarr = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
                            thousands = thouarr[int.Parse(revstr[x].ToString()) - 1];
                            if (revstr[x - 1].ToString() == "0" && revstr[x - 2].ToString() == "0" && revstr[x - 3].ToString() == "0")
                            {
                                return thousands + "thousand";
                            }
                        }
                        break;
                }

            }

            return thousands+hundreds+tens+ones;
        }

    }
}
