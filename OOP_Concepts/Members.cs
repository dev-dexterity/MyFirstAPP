using System.Diagnostics;

namespace MyFirstAPP
{
    public class Members
    {
        //Members - private
        private string name;
        private string jobTitle;
        private int salary = 50000;

        //Member - public field
        public int age;

        //member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
                SharingPrivateInfo();
            else
                Console.WriteLine("Hi, my name is {0}, and my job title is " +
                    "{1} I am {2} years old", name, jobTitle, age);
            
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0} ", salary);
        }

        //Member Constructor
        public Members(string name, string jobTitle, int salary)
        {
            this.name = name;
            JobTitle = jobTitle;
            this.salary = salary;
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleaningup Statements
            Console.WriteLine("Destruction of Members object");
            Debug.Write("Destruction of Members object ");
        }
    }
}