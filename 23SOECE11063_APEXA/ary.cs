using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _23SOECE11063_APEXA
{
    internal class ary
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];

            Console.WriteLine("enter array element:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            int searchEle;
            Console.WriteLine("enter element to search:");
            searchEle = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] != searchEle)
                {
                    flag = 1;

                }
                if (flag == 1)
                {
                    Console.WriteLine("element is found");
                    break;
                }
                else
                {
                    Console.WriteLine("element is not found");
                }
            }
        }
    }
}
