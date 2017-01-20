using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> rates = new Dictionary<string, decimal>();
            rates.Add("BGN", 1.0m);
            rates.Add("USD", 1.79549m);
            rates.Add("EUR", 1.95583m);
            rates.Add("GBP", 2.53405m);
            var amount = decimal.Parse(Console.ReadLine());
            string inCurrency =Console.ReadLine().ToUpper();
            string outCurrency = Console.ReadLine().ToUpper();
            decimal convertedCurrency=0;
            if (inCurrency=="BGN")
            {
                convertedCurrency = amount / rates[outCurrency];

            }
                else
                {
                    convertedCurrency = (amount * rates[inCurrency]) / rates[outCurrency];
                }

            Console.WriteLine(Math.Round(convertedCurrency, 2) + " " + outCurrency);
           

        }
    }
}
