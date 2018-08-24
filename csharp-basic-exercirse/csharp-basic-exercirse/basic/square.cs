using System;
using System.Runtime.InteropServices;

namespace csharp_basic_exercirse.basic
{
    class square
    {
        public void Square()
        {
            //Write a program which asks for a number and a width, 
            //and displays a square of that width, 
            //using that number for the inner symbol, as in this example:

            //Enter a number: 4

            //Enter the desired width: 3

            //444
            //444
            //444

            int number, width;
            int row, column;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());

            for (row = 0; row < width; row++)
            {
                for (column = 0; column < width; column++)
                {
                    Console.Write(number);
                }

                Console.WriteLine();
            }



           



        }

    }
}
