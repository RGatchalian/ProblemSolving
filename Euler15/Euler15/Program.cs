using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lattice is:" + GetLatticePoint(20));
        }
        static long GetLatticePoint(long gridsize)
        {
            long path = 1;
            for(long x = 0; x < gridsize; x++)
            {
                path *= (2 * gridsize) - x;
                path /= x + 1;
            }
            return path;
        }
    }
}
