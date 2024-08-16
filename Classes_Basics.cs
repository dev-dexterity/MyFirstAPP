namespace MyFirstAPP
{
    //this class is a blueprint for a datatype
    public class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi,I am {0} {1}",firstName,lastName);
        }
    }
}