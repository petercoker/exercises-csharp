using System;

namespace csharp_basic_exercirse.basic
{
    public class Age
    {
        public void Ages()
        {
            //Write a C# program to ask the user for his age (20, for instance) and answer something as "You look younger than 20" (instead of 20, you should display the age that has been entered).

            //    Output

            int age;

            Console.Write("Please enter a your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than {0} ", age);
        }
    }
}
