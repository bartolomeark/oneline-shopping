using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Class1
    {
        static void loginMethod()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write(": Default user name and password is :abcd and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                {
                    ctr++;
                }
                else
                {
                    ctr = 1;

                }
            }
            while ((username != "abcd" || password != "1234") && (ctr != 3));

            if (ctr == 3)
            {
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
                Console.WriteLine("Try again in 5 seconds.");
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);

                }

            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Confirming...");

                    Thread.Sleep(4000);
                }
                Console.Write("\nThe password entered successfully!\n\n");
                Console.Write("------------------------------------------------------\n");
            }
        }
    }
}
