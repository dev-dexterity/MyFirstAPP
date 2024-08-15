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
            /*
             **Variables and Datatypes
             * MyFirstAPP.Variables.Var();
             * MyFirstAPP.SwapVariables.Swapping();
             
             **Methods
             * Console.Write("Your Desired output is: " + MyFirstAPP.Methods.Add(num1, num2));
             * Console.WriteLine(MyFirstAPP.Methods.Subtract(a, b));
             * Console.WriteLine(MyFirstAPP.Methods.Multiply(a, b));
             * Console.WriteLine(MyFirstAPP.Methods.Divide(a, b));
             
             **UserInput
             * MyFirstAPP.UserInput.UserInputs();
             * Console.Write("Type Your first number: ");
             * string num1Input = Console.ReadLine();
             * Console.Write("Type Your Second number: ");
             * string num2Input = Console.ReadLine();
             * int num1 = int.Parse(num1Input);
             * int num2 = int.Parse(num2Input);//parsing  is effective if you have specific input
             * 
             **Catching Errors
             * MyFirstAPP.TryCatchErrors.ErrorHandling();
             * MyFirstAPP.ErrorHandlingExercise.ErrorHandling();
             * 
             **Operators
             * MyFirstAPP.Operators.Operations();
             *
             **Conditional Statements(if Statement)
             * MyFirstAPP.IfElse.Conditions();
             * MyFirstAPP.NestedifStatements.ConditionNested();
             * MyFirstAPP.SwitchCase.SwitchCaseStatement();
             * MyFirstAPP.SwitchCaseExe.SwitchCaseExercise();
             *
             **TryParseMethod
             * MyFirstAPP.TryParse.ConversionToInt();
             * 
             **Loops
             * MyFirstAPP.Forloop.loops();
             */
            MyFirstAPP.DoWhileLoop.loops();

            Console.WriteLine();
            Console.WriteLine("Thank You!");
        }
    }
}
