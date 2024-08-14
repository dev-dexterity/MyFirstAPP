namespace MyFirstAPP
{
    public class IfElse
    {
        public static void Conditions()
        {
            Console.WriteLine("What's the temperature like?");
            string temperature;
            temperature = Console.ReadLine();
            int temp = 0;

            if(int.TryParse(temperature, out temp))
            {
                Console.WriteLine("The temperature you entered is {0}", temp);
            }
            else
            {
                temp = 0;
                Console.WriteLine("Value entered is Wrong.The temprature is set to {0}.", temp);
                return;
            }


            //Conditional statements (if statements)
            if (temp < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 10)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }
        }
    }
}