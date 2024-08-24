using System;
using System.Collections;


namespace MyFirstAPP
{
    public class ArrayList
    {
        public static void ArrayLists()
        {
            List<Object> list = new List<Object>();
            list.Add(1);
            list.Add("hey");
            list.Add(3.14);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("The values in the list are {0}",list.Count);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            list.Remove(3.14);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            list.RemoveAt(0);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
