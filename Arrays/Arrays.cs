using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace MyFirstAPP
{
    public class Arrays
    {
        public static void ArrayLecture()
        {
            int[] arr = new int[] {1,2,3,4,2,3,2,3,5,1};
            Console.WriteLine("Before changing [{0}]", string.Join(",", arr));
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                
            }
            Console.WriteLine("After changing [{0}]", string.Join(",", arr));

            int input = Convert.ToInt32(Console.ReadLine());
            arr[0] = input;
            Console.WriteLine("After changing only one value [{0}]", string.Join(",", arr));
            Console.WriteLine("array value at index 0 changed to : {0}", arr[0]);

        }
    }
}