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
            //MyFirstAPP.Variables.Var();
            //MyFirstAPP.SwapVariables.Swapping();
            Console.WriteLine(MyFirstAPP.Methods.Add(20, 10));
            Console.WriteLine(MyFirstAPP.Methods.Subtract(20, 10));
            Console.WriteLine(MyFirstAPP.Methods.Multiply(20, 10));
            Console.WriteLine(MyFirstAPP.Methods.Divide(20, 10));

            Console.WriteLine();
            Console.WriteLine("Thank You!");
        }
    }
}
