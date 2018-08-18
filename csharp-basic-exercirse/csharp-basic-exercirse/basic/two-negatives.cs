using System;

namespace csharp_basic_exercirse.basic
{
    class two_negatives
    {
        public void twoNegative()
        {
            //Create a program to accept two numbers from the user and answer if both are negative or not. 

            int number1, number2;

            Console.Write("Enter your first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 >= 0 && number2 >=0)
            {
                Console.WriteLine("Both Positive");
            }

            else if (number1 <= -1)
            {
                Console.WriteLine("Your first number {0} is negative and second number {1} is positive", number1, number2);
            }

            else if (number2 <= -1)
            {
                Console.WriteLine("Your first number {0} is positive negative and second number {1} is negative", number1, number2);
            }

            else
            {
                Console.WriteLine("Both are negative");
            }

            //int number1;
            //int number2;

            //Console.Write("number 1: ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("number 2: ");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //if ((number1 < 0) && (number2 < 0))
            //    Console.WriteLine("the numbers are negative");

            //if (!((number1 < 0) && (number2 < 0)))
            //    Console.WriteLine("the numbers are NOT negative");
        }
    }
}
