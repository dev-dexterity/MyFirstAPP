using System.Data;

namespace MyFirstAPP
{
    public class ErrorHandlingExercise
    {
        public static void ErrorHandling()
        {
            int num1 = 1;
            int num2 = 0;

            int result = 0; ;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception, Cannot Divide by Zero.");
            }

            Console.WriteLine(result);
        }
    }
}