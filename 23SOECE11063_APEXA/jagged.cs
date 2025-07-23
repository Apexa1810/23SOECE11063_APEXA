using System;

namespace _23SOECE11063_APEXA
{
    internal class Jagged
    {
        public static void Main(string[] args)
        {
            int[][] jAry = new int[4][];
            jAry[0] = new int[4]; // 1st row contains 4 columns
            jAry[1] = new int[3];
            jAry[2] = new int[2];
            jAry[3] = new int[1];
            jAry[4] = new int[4];
            jAry[5] = new int[3];
            jAry[6] = new int[2];
            jAry[7] = new int[1];
            Console.WriteLine("Enter elements for the jagged array:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write($"Element [{i}][{j}]: ");
                    jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged array is:");
            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j] + " ");
                }
                Console.WriteLine(); // new line after each row
            }
            Console.WriteLine("\nFully Reversed Jagged Array:");
            for (int i = jAry.Length - 1; i >= 0; i--)
            {
                for (int j = jAry[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(jAry[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}