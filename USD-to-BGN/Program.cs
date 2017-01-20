using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountUSD = decimal.Parse(Console.ReadLine());
            var amountBGN = amountUSD * 1.79549m;
            Console.WriteLine(Math.Round(amountBGN, 2) + " BGN");
        }
    }
}
