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
             * MyFirstAPP.DoWhileLoop.loops();
             * MyFirstAPP.WhileLoop.loops();
             * 
             **Classes And Objects
             * creating object of my class
             * also called instance of Human
             * Human omkar = new Human();
             * Console.Write("Enter your FirstName: ");
             * omkar.firstName = Console.ReadLine();
             * Console.Write("Enter your LastName: ");
             * omkar.lastName = Console.ReadLine();
             * omkar.IntroduceMyself();
             * 
             * Human anagha = new Human();
             * Console.Write("Enter your FirstName: ");
             * anagha.firstName = Console.ReadLine();
             * Console.Write("Enter your LastName: ");
             * anagha.lastName = Console.ReadLine();
             * anagha.IntroduceMyself();
             */

            Human omkar = new Human("Omkar", "Gaikwad","Black",22);
            omkar.IntroduceMyself();

            Human anagha = new Human("Anagha", "Sawatkar", "Blue");
            anagha.IntroduceMyself();

            Human rahul = new Human("Rahul", "Gaikwad", 58);
            rahul.IntroduceMyself();

            Human tejas = new Human("Tejas", "Gaikwad");
            tejas.IntroduceMyself();

            Human khushi = new Human("Khushi");
            khushi.IntroduceMyself();

            Console.WriteLine();
            Console.WriteLine("Thank You!");
        }
    }
}
