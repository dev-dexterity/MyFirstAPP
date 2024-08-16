using System.Data;

namespace MyFirstAPP
{
    class SwapVariables
    {
        public static void Swapping()
        {
            int num1 = 12;
            int num2 = 13;
            int temp = 0;
            Console.WriteLine("Before Swapping: " + "num1 = " +  num1 + " num2 = " +  num2);
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping: " + "num1 = " + num1 + " num2 = " + num2);
        }
    }
}