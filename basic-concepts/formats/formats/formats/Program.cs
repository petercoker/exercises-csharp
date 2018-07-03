using System;

namespace formats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to ask the user for a number and display ir four times in a row, separated with blank spaces, and then four times in the next row, with no separation. You must do it two times: first using Console.Write and then using {0}.

            //    Output

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.Write(number);
            //}

            int n;

            Console.WriteLine("Enter a digit: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.WriteLine();

            Console.Write(n);
            Console.Write(n);
            Console.Write(n);
            Console.WriteLine(n);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", n);

            Console.WriteLine("{0}{0}{0}{0}", n);





        }
    }
}
