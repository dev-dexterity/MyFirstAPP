using System;

namespace MyFirstAPP
{
    public class ArraysTwoDimensional
    {
        public static void Arrays()
        {
            string[,] matrix;
            //3d array
            int[,,] threeD = new int[3,3,3];

            //two dimensional array
            int[,] array2D = new int[3,2]
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            array2D[1, 1] = 8;
            int dimensions = array2D.Rank;
            Console.WriteLine("The dimensions of the array are {0}", dimensions);

            dimensions = threeD.Rank;
            Console.WriteLine("The dimensions of the array are {0}", dimensions);

           
        }
    }
}