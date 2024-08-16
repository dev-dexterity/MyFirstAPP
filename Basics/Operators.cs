namespace MyFirstAPP
{
    public class Operators
    {
        public static void Operations()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary Opreators
            num3 = -num1;
            Console.WriteLine("num3 is {0} {1}",num3,num2);

            bool isSunnny = true;
            Console.WriteLine("is it sunny {0}", !isSunnny);

            //Increment opeartors
            int num = 0;
            num++;
            Console.WriteLine("num is {0}",num);
            Console.WriteLine("num is {0}",num++);
            //pre increment
            Console.WriteLine("num is {0}",++num);

            //decrement
            int num6 = 10;
            num6--;
            Console.WriteLine("num is {0}", num6);
            Console.WriteLine("num is {0}", num6--);
            //pre decrement
            Console.WriteLine("num is {0}", --num6);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);

            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //Relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("The comparison between num1 < num2 is {0}", isLower);

            isLower = num1 < num2;
            Console.WriteLine("The comparison between num1 > num2 is {0}", isLower);

            //Equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("The comparison between num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("The comparison between num1 != num2 is {0}", isEqual);

            //Conditional Operators
            bool isLowerAndSunny;
            //Condition1 AND condition2
            isLowerAndSunny = isLower && isSunnny;
            Console.WriteLine("The comparison between isLower && isSunny is {0}", isLowerAndSunny);

            //Condition1 OR condition2
            isLowerAndSunny = isLower || isSunnny;
            Console.WriteLine("The comparison between isLower || isSunny is {0}", isLowerAndSunny);



        }
    }
}