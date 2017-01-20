using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string bd = Console.ReadLine();
            DateTime birthDay = DateTime.ParseExact(bd, format, CultureInfo.InvariantCulture);
            var res = birthDay.AddDays(999).ToString(format);
            Console.WriteLine(res);
     

        }
    }
}
