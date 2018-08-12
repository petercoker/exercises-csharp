using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Services;

namespace csharp_basic_exercirse.basic
{
    class greatest_of_three_numbers
    {
        public void greatestNumber()
        {
            //Write a C# program to get three numbers from 
            //the user and display the greatest one.

            int number1, number2, number3;

            Console.Write("Enter 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("{0} is the great", number1);
            }

            else if ( number2 > number1 && number2 > number3)
            {
                Console.WriteLine("{0} is the great", number2);
            }

            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine("{0} is the great", number3);
            }

            else
            {
                Console.WriteLine("Its equal!");
            }
        }
        
    
    }
}
