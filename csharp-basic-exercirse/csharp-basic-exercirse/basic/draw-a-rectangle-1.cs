using System;

namespace csharp_basic_exercirse.basic
{
    class draw_a_rectangle_1
    {
        public void Draw()
        {
            //Write a program in C # to draw a rectangle on the screen. The measurements of the rectangle will be 3 columns wide and 5 rows tall. Use a digit entered by the user to draw it.

            //    Input
            //7

            //Output
            //777
            //777
            //777
            //777
            //777

            string digit = Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}{0}{0}", digit);
            }

            //Console.WriteLine("{0}{0}{0}", digit);
            //Console.WriteLine("{0} {0}", digit);
            //Console.WriteLine("{0} {0}", digit);
            //Console.WriteLine("{0} {0}", digit);
            //Console.WriteLine("{0}{0}{0}", digit);
        }
    }
}
