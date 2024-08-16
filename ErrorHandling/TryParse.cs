namespace MyFirstAPP
{
    public class TryParse
    {
        public static void ConversionToInt()
        {
            string numberAsString = "128";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
            {
                Console.WriteLine("The Parsing was Successful and the parsed value is {0}", parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing Failed");
            }
            
        }
    }
}