using System.Data;
using System.Drawing;

namespace MyFirstAPP
{
    //this class is a blueprint for a datatype
    public class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called.Object creadted.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName,string lastName)
        {
            this.firstName=firstName;
            this.lastName=lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //parameterized Constructor
        public Human(string firstName, string lastName,string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        //member method
        public void IntroduceMyself()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
                Console.WriteLine("Hi,I am {0} {1} and I am {2} year old and my EyeColor is {3} ", firstName, lastName, age, eyeColor);
            else if (lastName == null && eyeColor == null && age == 0)
                Console.WriteLine("Hi I am {0}", firstName);
            else if (eyeColor == null && age == 0)
                Console.WriteLine("Hi I am {0} {1} ", firstName, lastName);
            else if (age == 0)
                Console.WriteLine("Hi,I am {0} {1} and my EyeColor is {2} ", firstName, lastName, eyeColor);
            else if (eyeColor == null)
                Console.WriteLine("Hi I am {0} {1} and my age is {2} ", firstName, lastName, age);

        }
    }
}