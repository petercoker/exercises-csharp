using System;

namespace csharp_basic_exercirse.basic
{
    class positive_and_negative
    {
        public void PositivAndNegative()
        {
            //Write a C# program to get a number from the and answer whether it is positive or negative.

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("It's a positive number");
            }

            else
            {
                Console.WriteLine("It's a negetive number");
            }

        }

    }
}
