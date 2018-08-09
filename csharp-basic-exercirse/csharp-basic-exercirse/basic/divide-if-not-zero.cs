using System;

namespace csharp_basic_exercirse.basic
{
    class divide_if_not_zero
    {
        public void divideif()
        {
            //Write a C# program to ask the user for two numbers, 
            //and show their division if the second number is not zero;
            //otherwise, it will display "I cannot divide".

            int firstNumber, secondNumber;
   
            Console.Write("Enter first Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber != 0 && secondNumber != 0)
            {
                Console.WriteLine("The result for {0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            }

            else
            {
                Console.WriteLine("Result is 0");
            }
        }


    }
}
