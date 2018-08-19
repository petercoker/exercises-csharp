using System;

namespace csharp_basic_exercirse.basic
{
    class password2
    {
        public void passwordTwo()
        {
            //Write a program to ask the user for his / her login and his / her password(both must be integer numbers), 
            //until the entered login is "12" and the password is "1234".The user will have 3 attempts maximum.

            int user = 12, password = 1234, count = 0;
            const int Attempts = 3;

            do
            {
                Console.Write("Please enter your login number: ");
                user = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter your password number: ");
                password = Convert.ToInt32(Console.ReadLine());

                if (((user != 12) || (password != 1234)))
                {
                    Console.WriteLine("Login or Password is incorrect, try again\n");
                    count++;
                }
            } while (((user != 12) || (password != 1234)) && (count != Attempts));

            Console.WriteLine((user != 12) || (password != 1234) ? "Login attempts reached, account locked!" : "Login in successful");

            //for (int i = 0; i != 4; i++)
            //{
            //    if (i == 3)
            //    {
            //        Console.WriteLine("Login attempts reached, account locked!");
            //        break;
            //    }

            //    else
            //    {
            //        Console.Write("Please enter your login number: ");
            //        user = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Please enter your password number: ");
            //        password = Convert.ToInt32(Console.ReadLine());

            //        if (((user == 12) && (password == 1234)))
            //        {
            //            Console.WriteLine("Login successful");
            //            break;
            //        }

            //        else
            //        {
            //            Console.WriteLine("Login or Password is incorrect, try again\n");
            //        }
            //    }
            //}



            //int user, pass;
            //int counter = 0;

            //do
            //{
            //    Console.Write("Enter a user:  ");
            //    user = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a password:  ");
            //    pass = Convert.ToInt32(Console.ReadLine());

            //    if ((user != 12) || (pass != 1234))
            //    {
            //        Console.WriteLine("Login Error");
            //        counter++;
            //    }

            //}
            //while (((user != 12) || (pass != 1234)) && (counter != 3));

            //if ((user != 12) || (pass != 1234))
            //    Console.WriteLine("Logged out!");
            //else
            //    Console.WriteLine("Login successful");
        }
    }
}
