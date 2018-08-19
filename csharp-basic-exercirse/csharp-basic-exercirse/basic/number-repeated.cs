using System;
using System.CodeDom.Compiler;
using System.Runtime.Remoting.Services;

namespace csharp_basic_exercirse.basic
{
    class number_repeated
    {
        public void numberRepeat()
        {
            //Write a program which asks for a number and an amount,
            //and shows that number repeated as many times as the user has indicated,
            //as in the following example:

            //Enter a number: 4
            //Enter an amount: 5

            //44444

            //You must display it three times: first using "while", then "do-while" and finally "for".

            int number, amount, count;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            count = 0;
            while (count < amount)
            {
                Console.Write(number);
                count++;
            }

            Console.WriteLine();

            count = 0;
            do
            {
                Console.Write(number);
                count++;
            }
            while (count < amount);

            Console.WriteLine();

            for (int i = 0; i < amount; i++)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            //int num, amount;
            //int i;

            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter an amount: ");
            //amount = Convert.ToInt32(Console.ReadLine());

            //for (i = 0; i < amount; i++)
            //    Console.Write(num);

            //Console.WriteLine();

            //i = 0;
            //while (i < amount)
            //{
            //    Console.Write(num);
            //    i++;
            //}

            //Console.WriteLine();

            //i = 0;
            //do
            //{
            //    Console.Write(num);
            //    i++;
            //}
            //while (i < amount);
            }

    }
        
}
