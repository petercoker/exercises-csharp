using System;

namespace csharp_basic_exercirse.basic
{
    class several_mutiplication_tables_do_while
    {
        public void mutiplicationTable()
        {
            //Display the multiplication tables from 2 to 6, using nested "do...while" statements.


            //First Attempt
            //int number = 1, twoMultiplier = 2, sixMultiplier = 6, tableCount = 12;


            //do
            //{
            //    Console.WriteLine("{0} x {1} = {2}", number, twoMultiplier, number * twoMultiplier);
            //    number++;

            //    if (number < 12)
            //    {
            //        do
            //        {
            //            Console.WriteLine("{0} x {1} = {2}", number, sixMultiplier, number * sixMultiplier);
            //            number++;
            //        } while (number <= 12);
            //    }


            //} while (number);
            
            //Second Attempt
            int number = 2, multiplierNumber;
            const int MultiplierLimit = 6, TableLimit = 12;

            do
            {
                multiplierNumber = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}", number, multiplierNumber, number * multiplierNumber);
                    multiplierNumber++;

                } while (multiplierNumber <= TableLimit);

                Console.WriteLine();
                number++;
            } while (number <= MultiplierLimit);

        }
    }
}
