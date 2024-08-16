using System;

namespace MyFirstAPP
{
    class Variables
    {
        
       public static void Var()
       {
            /*string username = "Default";
            string password = "Default";

            Console.WriteLine("Your username is: " + username + "\n" + "Your password is: " + password + "\n");

            //Logic 

            //Successfully Registered

            Console.WriteLine("******After Registration******\n");

            username = "omiii_358";
            password = "Omkar@123";

            Console.WriteLine("Your username is: " + username + "\n" + "Your password is: " + password);*/
            //Explictly declared variables
            float valueAddedTax = 18f;
            float productA = 3.99f;
            float productB = 11.99f;
            float productC = 5.75f;

            float summed = productA + productB + productC;
            float totalTax = (summed / 100) * valueAddedTax;

            summed += totalTax;
            Console.WriteLine("Calculation done using Explicitly declared variables\n");
            Console.WriteLine("The total cost with the tax: " + summed + "\n");

            //Implicitly declared variables
            var integer = 100;
            var str = "hello";
            var boolean = true;
            var character = 'a';
            var floatingPoint = 3.14f;

            Console.WriteLine("Implicitly declared variables: \n\nInteger: " + integer + "\nString: " + str + "\nBoolean: " + boolean + "\nCharacter: " + character + "\nFloating Point: " + floatingPoint);


       }

    } 
}