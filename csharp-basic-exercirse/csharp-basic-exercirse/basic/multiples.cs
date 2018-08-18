using System;

namespace csharp_basic_exercirse.basic
{
    class multiples
    {
        public void Multiple()
        {
            //Create a program to write on screen the numbers from 1 to 500 that are multiples of 3 
            //and also multiples of 5(hint: use the remainder of the division).

            for (int i = 1; i < 500; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //int i = 1;

            //for (i = 1; i <= 500; i++)
            //{
            //    if ((i % 3 == 0) && (i % 5 == 0))
            //        Console.Write("{0} ", i);
            //}
        }
    }
}
