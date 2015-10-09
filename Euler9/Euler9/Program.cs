using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler9
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 0;
            int answer = 0;
            int num1=0, num2=0, num3=0;
            for(int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (isPythagoreanTriplet(c, (Square(a) + Square(b))))
                        {
                            answer = a + b + c;
                            Console.WriteLine("PYTHAGOREAN: {0} + {1} = {2}", a, b, c);
                            if (answer == 1000)
                            {
                                num1 = a;
                                num2 = b;
                                num3 = c;
                                c = 1000;
                                b = 1000;
                                a = 1000;
                            }
                        }
                    }
                }
            }
 
            product = num1 * num2 * num3;
            Console.WriteLine("{0} + {1} = {2}",num1,num2,num3);
            Console.WriteLine("Product is:" + product);
            Console.ReadLine();
        }
        static bool isPythagoreanTriplet(int num, int val)
        {
            double ans = Math.Sqrt(val);
            if (ans == num)
            {
                return true;
            }
            return false;
        }

        static int Square(int num)
        {
            return num * num;
        }
    } 
}
