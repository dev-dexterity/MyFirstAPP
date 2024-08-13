using System.Threading.Channels;

namespace MyFirstAPP
{
    public class TryCatchErrors
    {
        public static void ErrorHandling()
        {
            Console.WriteLine("Please Enter a number");
            string userInput = Console.ReadLine();

            int userInputAsInt = int.Parse(userInput);

            Console.WriteLine(userInputAsInt);
        }
    }
}