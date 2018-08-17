using System;

namespace csharp_basic_exercirse.basic
{
    class times_table
    {
        public void times()
        {
            //Write a C# program to ask the user for a number and display its multiplication table, using a "while" statement. 
            //The result must be like this: 
            //5 x 1 = 5
            //5 x 2 = 10
            //5 x 3 = 15
            //    ...
            //5 x 10 = 50

            int number, multiplicationNumber = 1;

            Console.Write("Insert a number to multiply: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (multiplicationNumber <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", number, multiplicationNumber, number * multiplicationNumber);
                multiplicationNumber++;
            }

            //int num, multiplier = 1;

            //Console.Write("Insert a number to multiply: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (multiplier <= 10)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", num, multiplier, num * multiplier);
            //    multiplier++;
            //}
        }
    }
}
