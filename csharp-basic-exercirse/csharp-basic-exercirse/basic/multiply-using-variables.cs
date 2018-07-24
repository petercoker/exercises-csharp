using System;

namespace csharp_basic_exercirse.basic
{
    class multiply_using_variables
    {
        public void variables()
        {
            //Write a C# program to print the result of multiplying two numbers which will entered by the user. Compile it using Mono. Check that the resulting EXE file works properly.

            //    Output


            int number1, number2, sum;


            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2;
            Console.WriteLine("Answer:{0}", sum);

        }
    }
}
