using System;

namespace MyFirstAPP
{
    public class LoopsExercise
    {
        public static void Exercise()
        {
            string[] Friends = new string[5] { "Anirudha", "Sohan", "Sandesh", "Siddhant", "Arhant" };
            int counter = 0;
            foreach (string name in Friends)
            {
                Console.WriteLine("{0}.Hello {1}", counter + 1, name);
                counter++;
            }
        }
    }
}