namespace MyFirstAPP
{
    public class SwitchCase
    {
        public static void SwitchCaseStatement()
        {
            Console.Write("Enter your First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter which operation you want to perform: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(MyFirstAPP.Methods.Add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(MyFirstAPP.Methods.Subtract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(MyFirstAPP.Methods.Multiply(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(MyFirstAPP.Methods.Divide(num1, num2));
                    break;
            }
        }
    }
}