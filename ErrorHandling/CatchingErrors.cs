using System.Threading.Channels;

namespace MyFirstAPP
{
    public class TryCatchErrors
    {
        public static void ErrorHandling()
        {
            Console.WriteLine("Please Enter a number");
            string userInput = Console.ReadLine();
            int userInputAsInt = 0;
            
            try
            {
                userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Input.Error Name: Format Exception, Please Enter the correct type next time.");
                
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Wrong Input.Error Name: OverFlow Exception, The number was too long or too short for an Integer");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Wrong Input.Error Name: Argument Null Exception, The value was Empty(null)");
            }
            finally
            {
                Console.WriteLine("Called Anyways " + userInputAsInt);
            }
            



        }
    }
}