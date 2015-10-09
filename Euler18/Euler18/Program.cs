using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Euler18
{
    class Program
    {
        static List<string> _datalist = new List<string>();
        static List<string> _newdatalist = new List<string>();
        static void Main(string[] args)
        {
            string filepath = System.Windows.Forms.Application.StartupPath + "\\datainput.txt";
            int rowlevel = 0;
            using (StreamReader sr = new StreamReader(filepath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    _datalist.Add(line.Replace(" ", ","));
                    rowlevel++;
                }
            }
            for(int x = 1; x < _datalist.Count; x++)
            {

                string[] parArr = _datalist[x - 1].Split(',');
                string[] chArr = _datalist[x].Split(',');
                string tmpStr = "";
                int prevcurval2 = 0;
                for(int p = 0; p <= parArr.GetUpperBound(0); p++)
                {
                    int curparnum= int.Parse(parArr[p]);
                    int curval1 = curparnum + int.Parse(chArr[p]);
                    int curval2 = curparnum + int.Parse(chArr[p+1]);
                    if (tmpStr == "")
                    {
                        if(curval1 > prevcurval2)
                        {
                            tmpStr += ReplaceValue(tmpStr, curval1.ToString()) + "," + curval2;
                        }
                        else
                        {
                            tmpStr += "," + curval2;
                        }
                    }
                    else
                    {
                        if (curval1 > prevcurval2)
                        {
                            tmpStr =ReplaceValue(tmpStr, curval1.ToString()) + "," + curval2;
                        }
                        else
                        {
                            tmpStr += "," + curval2;
                        }
                    }
                    prevcurval2 = curval2;

                }
                _datalist[x] = tmpStr;
                _newdatalist.Add(tmpStr);

            }
            int largest = 0;
            string[] nums = _newdatalist[(_newdatalist.Count - 1)].Split(',');
            foreach(string s in nums)
            {
                if (largest < int.Parse(s))
                {
                    largest = int.Parse(s);
                }
            }
            Console.WriteLine("The Answer is:" + largest);
            Console.ReadLine();
        }
        static string ReplaceValue(string s,string newvalue)
        {
            string[] arr = s.Split(',');
            arr[arr.GetUpperBound(0)] = newvalue;
            string tmpstr = "";
            foreach(var ns in arr)
            {
                if (tmpstr == "")
                {
                    tmpstr = ns;
                }
                else
                {
                    tmpstr += "," +  ns;
                }
            }
            return tmpstr;
            

        }
    }
}
