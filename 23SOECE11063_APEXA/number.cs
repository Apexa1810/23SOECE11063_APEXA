using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOECE11063_APEXA
{
    internal class number
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter  number");
            String mobile = Console.ReadLine();

            if (mobile.Length >= 5) ;
            {
                string number = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine(number);
            }

        }
    }
}
