using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Euler13
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = GetSumFileString(System.Windows.Forms.Application.StartupPath + "\\datainput.txt");
            Console.WriteLine(ans);
        }
        static string GetSumFileString(string path)
        { 
            double sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    sum += double.Parse(line);
                }
            }
            return sum.ToString();
        }

    }
}
