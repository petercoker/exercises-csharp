using System;
using System.Runtime.InteropServices;

namespace csharp_basic_exercirse.basic
{
    class sum_numbers
    {
        public void sum()
        {
            //Write a C# program to ask the user for an undetermined amount of numbers (until 0 is entered) 
            //and display their sum, as follows: 

            //Number? 5
            //Total = 5
            //Number ? 10
            //Total = 15
            //Number ? -2
            //Total = 13
            //Number ? 0
            //Finished

            int number, sum = 0;

            while (true)
            {
                Console.Write("Enter a number?: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Finished");
                    break;
                }

                sum = number + sum;

                Console.WriteLine("Total = {0}", sum);
            }

            //int number;
            //int sum = 0;

            //do
            //{
            //    Console.Write("Number: ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    sum = number + sum;

            //    if (number != 0)
            //        Console.WriteLine("Total: {0}", sum);
            //}
            //while (number != 0);

            //Console.WriteLine("Finished");
        }
    }
}
