using System;

namespace csharp_basic_exercirse.basic
{
    class repeat
    {
        public void repeats()
        {
            //Create a C# program to ask the user for a number "x" and display 10*x. 
            //It must repeat until the user enters 0 (using "do-while").

            int x;

            do
            {
                Console.Write("Enter a number: ");
                x = int.Parse(Console.ReadLine());

                if (x != 0)
                {
                    Console.WriteLine(x * 10);
                }

                else
                {
                    break;
                }

            } while (true);

            int number;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(number * 10);
            //}
            //while (number != 0);

        }
    }
}
