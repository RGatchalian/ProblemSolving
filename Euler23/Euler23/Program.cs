using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler23
{
    class Program
    {
        static void Main(string[] args)
        {
            var limit = 28123;
            var ans = 0;
            List<int> _abundant = new List<int>();
            for (int x=1;x<= limit; x++)
            {
                NumberType nt = EvaluateNumber(x);
                if (nt == NumberType.ABUNDANT)
                {
                    _abundant.Add(x);
                }
            }
            bool[] SumofAbundantNumbers = new bool[limit + 1];
            for (int i = 0; i < _abundant.Count; i++)
            {
                for (int j = i; j < _abundant.Count; j++)
                {
                    if (_abundant[i] + _abundant[j] <= limit)
                    {
                        SumofAbundantNumbers[_abundant[i] + _abundant[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 1; i <= limit; i++)
            {
                if (!SumofAbundantNumbers[i])
                {
                    ans += i;
                }
            }
            Console.WriteLine("Answer is:"  + ans);
            Console.ReadLine();
        }
        static NumberType EvaluateNumber(long num)
        {
            List<int> _div = GetDivisors(num);
            long ans = 0;
            foreach(var n in _div)
            {
                ans += n;
            }
            if (num == ans)
            {
                return NumberType.PERFECT;
            }
            else if(num < ans)
            {
                return NumberType.ABUNDANT;
            }
            else
            {
                return NumberType.DEFICIENT;
            }
        }
        static List<int> GetDivisors(long num)
        {
            List<int> _tmp = new List<int>();
            if (num == 1)
            {
                _tmp.Add(1);
            }
            else
            {
                for (int x = 1; x < num; x++)
                {
                    if ((num % x) == 0)
                    {
                        _tmp.Add(x);
                    }
                }

            }
            return _tmp;
        }
    }
    enum NumberType
    {
        PERFECT=1,DEFICIENT,ABUNDANT
    }
}
