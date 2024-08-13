using System;


namespace MyFirstAPP
{
    public class Program
    {
        /// <summary>
        /// This is the Entry point of our program
        /// </summary>
        public static void Main(string[] args)
        {
            /*MyFirstAPP.Variables.Var();
            MyFirstAPP.SwapVariables.Swapping();
            Console.WriteLine(MyFirstAPP.Methods.Subtract(a, b));
            Console.WriteLine(MyFirstAPP.Methods.Multiply(a, b));
            Console.WriteLine(MyFirstAPP.Methods.Divide(a, b));

            MyFirstAPP.UserInput.UserInputs();*/
            Console.Write("Type Your first number: ");
            string num1Input = Console.ReadLine();

            Console.Write("Type Your Second number: ");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);//parsing  is effective if you have specific input


            Console.Write("Your Desired output is: " + MyFirstAPP.Methods.Add(num1, num2));
      
            Console.WriteLine();
            Console.WriteLine("Thank You!");
        }
    }
}
