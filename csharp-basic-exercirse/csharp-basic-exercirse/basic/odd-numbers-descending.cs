using System;
using System.Collections.Concurrent;

namespace csharp_basic_exercirse.basic
{
    class odd_numbers_descending
    {
        public void oddNumbers()
        {
            //Create a program to display on the screen 
            //the odd numbers from 15 to 7 (downwards), using "while". 

            int number = 15;

            while (number >= 7)
            {
                Console.WriteLine(number);
                number -= 2;
            }


            //Wrong attempt
            //int number = 15;
            //const int Divisble = 3;

            //while (number >= 7)
            //{
            //    if (number % Divisble == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    number--;
            //}

            //Console.WriteLine(number);

            
            //Answer: 7, 9, 11, 13, 15
            int n = 15;

            while (n >= 7)
            {
                Console.WriteLine(n);
                n -= 2;
            }

        }
    }
}
