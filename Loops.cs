namespace MyFirstAPP
{
    public class Forloop
    {
        public static void loops()
        {
            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine("The Odd number is {0} ",i);
            }
        }
    }

    public class DoWhileLoop
    {
        public static void loops()
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.Write("Please enter you Name: ");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            }while (lengthOfText < 20);
            Console.WriteLine("Hello! {0} ", wholeText);
        }

    }

    public class WhileLoop
    {
        public static void loops()
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one.");
                enteredText = Console.ReadLine();
                
                counter++;
                Console.WriteLine("Entered people are: {0}", counter);
            }
            Console.WriteLine("{0} people are entered the bus.Please press enter to close the program", counter);
        }
    }
}