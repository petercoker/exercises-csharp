using System;
using System.Diagnostics.Eventing.Reader;

namespace csharp_basic_exercirse.basic
{
    class many_divisions
    {
        public void ManyDivisions()
        {
            //Write a C# program to ask the user for two numbers and show their division and the remainder of the division. 
            //It will warn if 0 is entered as second number, and end if 0 is entered as first number:

            //First number ? 10
            //Second number ? 2
            //Division is 5
            //Remainder is 0

            //First number? 10
            //Second number? 0
            //Cannot divide by 0

            //First number? 10
            //Second number? 3
            //Division is 3
            //Remainder is 1

            //First number? 0
            //Bye!

            int number1, number2;

            do
            {
                Console.Write("First number ? ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Second number ? ");
                number2 = Convert.ToInt32(Console.ReadLine());
                
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Division is {0}", number1 / number2);
                    Console.WriteLine("Remainder is {0}", number1 % number2);
                    Console.WriteLine();
                }
            } while (number1 != 0);

            Console.WriteLine("Bye!");

            //int num1, num2;
            //do
            //{
            //    Console.Write("First number? ");
            //    num1 = Convert.ToInt32(Console.ReadLine());

            //    if (num1 != 0)
            //    {
            //        Console.Write("Second number? ");
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Cannot divide by 0");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division is {0}", num1 / num2);
            //            Console.WriteLine("Remainder is {0}", num1 % num2);
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //while (num1 != 0);
            //Console.WriteLine("Bye!");


        }
    }
}
