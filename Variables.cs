using System;
using System.Threading.Channels;

namespace MyFirstAPP
{
    class Variables
    {
       public static void Var()
       {
            string username = "Default";
            string password = "Default";

            Console.WriteLine("Your username is: " + username + "\n" + "Your password is: " + password + "\n");

            //Logic 

            //Successfully Registered

            Console.WriteLine("******After Registration******\n");

            username = "omiii_358";
            password = "Omkar@123";

            Console.WriteLine("Your username is: " + username + "\n" + "Your password is: " + password);


        }

    }
}