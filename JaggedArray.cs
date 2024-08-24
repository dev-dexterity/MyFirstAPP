namespace MyFirstAPP
{
    public class JaggedArray
    {
        public static void JaggedArrays()
        {
            //declaration of jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray [1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alternative way of declaring jagged array
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

           

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i + 1);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray2[i][j]);
                    
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Element {0}", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray[i][j]);
                }
                Console.WriteLine("\n");
            }


        }
    }
}
