using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peter Coker

            //Write a C# program to calculate and display the average of four numbers entered by the user.

            //    Output

            //int number1, number2, number3, number4, average;

            //Console.Write("Enter first number: ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //number3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter four number: ");
            //number4 = Convert.ToInt32(Console.ReadLine());

            //average = (number1 + number2 + number3 + number4) / 4;
            //Console.WriteLine("Average of the four numbers is {0}", average);

            int average = 0;
            int number;

            for (int i = 1; i <=4; i++)
            {
                Console.Write("Enter the number {0}: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                average += number;
            }

            Console.WriteLine("Average is {0}", average / 4);


        }
    }
}
