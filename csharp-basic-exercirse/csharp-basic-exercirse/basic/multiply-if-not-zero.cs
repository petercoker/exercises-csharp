using System;
using System.Security.Cryptography.X509Certificates;

namespace csharp_basic_exercirse.basic
{
    class multiply_if_not_zero
    {
        public void multi()
        {
            //Write a C# program to ask the user for a number
            //if it is not zero, 
            //then it will ask for a second number and display their product; 
            //otherwise, it will display "0".

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumer = Convert.ToInt32(Console.ReadLine());


            if (firstNumber != 0 && secondNumer != 0)
            {
                Console.WriteLine("{0} x {1} = {2}", firstNumber, secondNumer, firstNumber * secondNumer);
            }

            else
            {
                Console.WriteLine("{0} x {1} = {2}", firstNumber, secondNumer, 0);
            }

            //int x, y;

            //Console.Write("enter x:");
            //x = System.Convert.ToInt32(System.Console.ReadLine());

            //Console.Write("enter y:");
            //y = System.Convert.ToInt32(System.Console.ReadLine());

            //if (x != 0 && y != 0)
            //    Console.WriteLine("{0} x {1} = {2}",
            //        x, y, x * y);
            //else
            //    Console.WriteLine("{0} x {1} = {2}",
            //        x, y, 0);
        }
    }
}
