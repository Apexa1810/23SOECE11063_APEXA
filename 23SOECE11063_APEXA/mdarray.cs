using System;


namespace _23SOECE11063_APEXA
{
    internal class mdarray
    {
        public static void Main(string[] args)
        {
            //1)
            //int[,] ary = new int[2, 2];
            //ary[0, 0] = 1;                            //[row,column]
            //ary[0, 1] = 2;
            //ary[1, 0] = 3;
            //ary[1, 1] = 4;

            //Console.WriteLine("First element: {0}", ary[0, 0]);
            //// Or: Console.WriteLine("First element: " + ary[0, 0]);

            //----------------------------------------------------------------

            //2)
            //int[,] ary = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine("First element:" +ary[0, 0]);

            //-------------------------------------------------------------------

            //3)
            //2*3 array

            int[,] ary = new int[3, 3]; 
            Console.WriteLine("Enter elements of 3*3 array:");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    ary[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < ary.GetLength(0); i++)   //number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++)   // number of columns
                {
                    Console.WriteLine(ary[i, j] + " ");
                }
                Console.WriteLine(" ");
            }


        }
    }

                }
    