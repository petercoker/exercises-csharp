using System;
using System.Runtime.Remoting.Services;

namespace csharp_basic_exercirse.basic
{
    class greatest_of_three_numbers
    {
        public void greatestNumber()
        {
            //Write a C# program to get three numbers from 
            //the user and display the greatest one.

            string[] numbers = new string[3];

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter {0} number: ", i);
                numbers [0] = Console.ReadLine();
                numbers[1] = Console.ReadLine();
                numbers[2] = Console.ReadLine();
            }

            
            
            
        }
        
    
    }
}
