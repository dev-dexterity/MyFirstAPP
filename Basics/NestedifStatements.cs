namespace MyFirstAPP
{
    public class NestedifStatements
    {
        public static void ConditionNested()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            Console.Write("Enter Your UserName: ");
            string userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, Registered User");
                if(userName != ""){
                    Console.WriteLine("Hi there, {0}",userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are Logged in!!");
            }
        }
    }
}
