using System;
using System.Xml.Schema;

namespace csharp_basic_exercirse.basic
{
    class repeat_until_0
    {
        public void repeat()
        {
            //Create a C# program to ask the user for a number "x" and display 10*x. 
            //It must repeat until the user enters 0 (using "while").

            //int x;

            //while (true)
            //{
            //    Console.Write("Enter a number: ");
            //    x = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine(x * 10);
            //    if (x == 0)
            //    {
            //        break;
            //    }
            //}


            int y;

            while (true)
            {
                Console.Write("Enter a number: ");
                y = Convert.ToInt32(Console.ReadLine());

                if (y != 0)
                {
                    Console.WriteLine(y * 10);

                }
                else
                {
                    break;
                }
            }

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //while (number != 0)
            //{
            //    Console.WriteLine(number * 10);

            //    Console.Write("Enter a number: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
        }
    }

}
