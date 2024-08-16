namespace MyFirstAPP
{
    public class SwitchCaseExe
    {
        public static void SwitchCaseExercise()
        {
            int age = 565;

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club");
            }
            else if (age == 19)
            {
                Console.WriteLine("Good to GO!");
            }
            else
            {
                Console.WriteLine("How Old are you Then????");
            }


            /*
             * If you are wondering where is the switch case then the question was like these:
             * convert the following code to ifElse statement
             * int age = 19;
             * switch(age);
             * { case 15: Console.WriteLine("Too young to party in the club"); break;
             *   case 25: Console.WriteLine("Good to GO!"); break;
             *   default: Console.WriteLine("How Old are you Then????");
             * }
             */
        }
    }
}