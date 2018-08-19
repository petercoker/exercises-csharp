using System;

namespace csharp_basic_exercirse.basic
{
    class password1
    {
        public void passwordOne()
        {
            //Write a program to ask the user for his/her login and his/her password (both must be integer numbers) 
            //and repeat it as many times as necessary, until the entered login is "12" and the password is "1234". 

            //while (true)
            //{
            //    int login = 12, password = 1234;

            //    Console.Write("Enter your login number: ");
            //    login = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter your password number: ");
            //    password = Convert.ToInt32(Console.ReadLine());
                
            //    if (login == 12 && password == 1234)
            //    {
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Wrong login and password, please try again");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Login and Password are right!");

            int login, password;

            do
            {
                Console.Write("Enter a login: ");
                login = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a password: ");
                password = Convert.ToInt32(Console.ReadLine());

                if ((login != 12) || (password != 1234))
                {
                    Console.WriteLine("Login Error");
                }
            } while ((login != 12) || (password != 1234));

            Console.WriteLine("Login successful");
        }
    }
}
