using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _23SOECE11063_APEXA
{
    internal class _2darry
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[2, 2];
            ary[0, 0] = 1;
            ary[0 ,1]= 2;
            ary[1 ,0] = 3;
            ary[1 ,1] = 4;
//this is initialization of array
            Console.WriteLine("first element:"+ ary[0,0]);
        }
    }
}
