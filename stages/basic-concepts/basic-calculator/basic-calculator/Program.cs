using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a basic calculador in C#  to perform a basic operations. The user can only enter a number on the screen. Ask the user for a number and then perform addition, subtraction, multiplication and division of the same number.
            //    Input
            //Enter a number: 4

            int num1, num2;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1++;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}",num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            
            //Peter Coker
        }
    }
}
