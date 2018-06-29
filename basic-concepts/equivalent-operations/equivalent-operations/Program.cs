using System;

namespace equivalent_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peter Coker

            //Write a C# program to ask the user for three numbers (a, b, c) and display the result of (a+b)·c and the result of a·c + b·c

            //    Output

            //int number, sum = 0;


            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.Write("Enter a number {0}: ", i);
            //    number = Convert.ToInt32(Console.ReadLine());
            //}

            
            //Console.WriteLine("Result by Addition and multiplication: {0}", sum); //Learn Arrays [i] could have been used

            int number1, number2, number3;

            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of operation between ({0}, {1}, {2}) \n Result of operation between (a+b).c is {3} \n Result of operation between a.b + a.c is {4}", number1, number2, number3, ((number1 + number2) * number3), (number1 * number3 + number2* number3));
            
        }
    }
}
