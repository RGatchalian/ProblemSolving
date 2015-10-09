using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler19
{
    class Program
    {
        static void Main(string[] args)
        {
            long sundaycount = 0;
            
            for(int year = 1901; year <= 2000; year++)
            {
                for(int month = 1; month <= 12; month++)
                {
                    DateTime d = new DateTime(year, month, 1);
                    if (d.DayOfWeek.ToString().ToUpper() == "SUNDAY")
                    {
                        sundaycount++;
                    }
                }
            }

            Console.WriteLine("Answer is:" + sundaycount);
            Console.ReadLine();
        }
    }
}
