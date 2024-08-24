using System;

namespace MyFirstAPP
{
    public class NestedLoops
    {
        public static void Loops()
        {
            int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            /*foreach(int item in matrix)
            {
                Console.Write(item + " ");
            }*/

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {  
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}