using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to ask the user for a number and display its multiplication table, like this: 

            //5 x 1 = 5
            //5 x 2 = 10
            //5 x 3 = 15
            //    ...
            //5 x 10 = 50

            int number;


            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int multiplcation = 1; multiplcation <= 10; multiplcation++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, multiplcation, number * multiplcation);
            }

            //Peter Coker

        }
    }
}
