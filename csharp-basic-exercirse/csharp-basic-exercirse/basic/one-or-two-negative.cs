using System;

namespace csharp_basic_exercirse.basic
{
    class one_or_two_negative
    {
        public void oneTwoNegative()
        {
            //Create a program to accept two numbers from the user and answer if both are negative, if only one is, or if none of them is. 
            
            Console.Write("Enter your first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your second: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 <= -1 && number2 <= -1)
            {
                Console.WriteLine("Both numbers are negative");
            }


            else if (number1 >= 0 && !(number2 >= 0))
            {
               Console.WriteLine("First number is poistive and Second number is negative");
            }

            else if (!(number1 >= 0) && number2 >= 0)
            {
                Console.WriteLine("First number is negative and Second number is positive");
            }

            else
            {
                Console.WriteLine("Both numbers are postive");
            }

            //int number1;
            //int number2;

            //Console.Write("number 1: ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("number 2: ");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //if ((number1 < 0) && (number2 < 0))
            //    Console.WriteLine("the numbers are negative");

            //else
            //if ((number1 >= 0) && (number2 >= 0))
            //    Console.WriteLine("none is negative");

            //else
            //    Console.WriteLine("one is negative");
        }

        

    }
}
