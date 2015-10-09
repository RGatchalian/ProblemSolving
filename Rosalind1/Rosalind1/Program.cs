using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosalind1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Symbols> _symbols = new List<Symbols>();
            string dataset = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
            _symbols.Add(new Symbols("A"));
            _symbols.Add(new Symbols("C"));
            _symbols.Add(new Symbols("G"));
            _symbols.Add(new Symbols("T"));
            for (int x = 0; x < dataset.Length; x++)
            {
                foreach (var s in _symbols)
                {
                    if (s.Symbol == dataset[x].ToString())
                    {
                        s.Count++;
                    }
                }
            }
            foreach (var s in _symbols)
            {
                Console.Write("{0} ",s.Count);
            }
        }
    }
    class Symbols
    {
        public string Symbol { get; set; }
        public int Count { get; set; }
        public Symbols(string symbol)
        {
            this.Symbol = symbol;
        }
    }
}
