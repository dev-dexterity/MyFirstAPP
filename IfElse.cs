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

            try
            {
                temp = int.Parse(temperature);
            }
            catch (Exception)
            {
                Console.WriteLine("The Following input is wrong.");
                return;
            }

            
            //Conditional statements (if statements)
            if(temp < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if(temp == 10)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }

            if(temp > 10)
            {
                Console.WriteLine("Shorts are enough today");
            }
        }
    }
}