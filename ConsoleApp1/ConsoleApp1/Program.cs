using System;
using System.Threading;

namespace ConsoleApp1
{
    class login
    {
        public void loginMethod()
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
                loginMethod();
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Confirming");
                    Console.WriteLine("Please Wait...");

                    Thread.Sleep(4000);
                }
                Console.Write("\nThe password entered successfully!\n");

            }
        }
    }
    class first
    {
        public void startingPoint()
        {


            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Welcome to Online Shopping System!");
            Console.WriteLine("Press v to view products.");
            Console.WriteLine("Press x to exit.");
            Console.Write("\n------------------------------------------------------\n");

            char exit = Console.ReadKey().KeyChar;
            switch (exit)
            {
                case 'x':
                    Console.WriteLine("\nAre you sure you want to exit?");
                    Console.WriteLine("\nPress y if yes then n if no");
                    string optionSelected5 = Console.ReadLine().ToLower();
                    if (optionSelected5.Equals("y"))
                    {

                        Console.WriteLine("Thank you! Please come again!");
                        Console.WriteLine("Closing...");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);

                        }
                    }
                    else if (optionSelected5.Equals("n"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Restarting...");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);

                        }
                        startingPoint();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option!");

                    }
                    break;
                case 'v':
                    Console.WriteLine("");
                    products os = new products();
                    os.onlineShopping();
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;

            }

        }
    }


        class products {

            public void onlineShopping()
            {
                string productName = "Ballpen";
                string productCategory = "School Supplies";
                int productQuantity = 500;


                string productName1 = "Shorts";
                string productCategory1 = "Trousers and Shorts";
                int productQuantity1 = 259;


                string productName2 = "Tshirt";
                string productCategory2 = "Shirts";
                int productQuantity2 = 201;


                string productName3 = "Bucket hat";
                string productCategory3 = "Cap";
                int productQuantity3 = 178;
                Console.Write("\n------------------------------------------------------\n");
                Console.WriteLine("Available Product:");
                Console.WriteLine("1." + productName);
                Console.WriteLine("2." + productName1);
                Console.WriteLine("3." + productName2);
                Console.WriteLine("4." + productName3);
                Console.Write("\n------------------------------------------------------\n");

                Console.Write("What product you want to buy: ");
                Console.WriteLine("Product: 1, 2, 3, or 4?");

                int optionSelected = Convert.ToInt32(Console.ReadLine());

                switch (optionSelected)
                {
                    case 1:
                        Console.WriteLine("Product:" + productName);
                        Console.WriteLine("Stock:" + productQuantity);
                        Console.WriteLine("How many would you like to buy?");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("you like to buy " + quantity, "?");
                        Console.WriteLine(" Type Y to confirm then N to cancel");
                        string optionSelected1 = Console.ReadLine().ToLower();
                        if (optionSelected1.Equals("y"))
                        {
                            int newproductQuantity = productQuantity - quantity;
                            Console.WriteLine("You buy " + quantity);
                            Console.WriteLine("Remaining stock is " + newproductQuantity);
                        }
                        else if (optionSelected1.Equals("n"))
                        {
                            Console.WriteLine("");
                            onlineShopping();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                            Console.WriteLine("Restarting...");
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);

                            }
                            onlineShopping();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Product:" + productName1);
                        Console.WriteLine("Stock:" + productQuantity1);
                        Console.WriteLine("How many would you like to buy?");
                        int quantity1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("you like to buy " + quantity1, "?");
                        Console.WriteLine(" Type Y to confirm then N to cancel");
                        string optionSelected2 = Console.ReadLine().ToLower();
                        if (optionSelected2.Equals("y"))
                        {
                            int newproductQuantity = productQuantity - quantity1;
                            Console.WriteLine("You buy" + quantity1);
                            Console.WriteLine("Remaining stock is " + newproductQuantity);
                        }
                        else if (optionSelected2.Equals("n"))
                        {
                            Console.WriteLine("");
                            onlineShopping();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                            Console.WriteLine("Restarting...");
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);

                            }
                            onlineShopping();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Product:" + productName2);
                        Console.WriteLine("Stock:" + productQuantity2);
                        Console.WriteLine("How many would you like to buy?");
                        int quantity2 = Convert.ToInt32(Console.ReadLine());
                        productQuantity2 -= quantity2;
                        Console.WriteLine("you like to buy " + quantity2, "?");
                        Console.WriteLine(" Type Y to confirm then N to cancel");
                        string optionSelected3 = Console.ReadLine().ToLower();
                        if (optionSelected3.Equals("y"))
                        {
                            int newproductQuantity = productQuantity - quantity2;
                            Console.WriteLine("You buy" + quantity2);
                            Console.WriteLine("Remaining stock is " + newproductQuantity);
                        }
                        else if (optionSelected3.Equals("n"))
                        {
                            Console.WriteLine("");
                            onlineShopping();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                            Console.WriteLine("Restarting...");
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);

                            }
                            onlineShopping();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Product:" + productName3);
                        Console.WriteLine("Stock:" + productQuantity3);
                        Console.WriteLine("How many would you like to buy?");
                        int quantity3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("you like to buy " + quantity3, "?");
                        Console.WriteLine(" Type Y to confirm then N to cancel");
                        string optionSelected4 = Console.ReadLine().ToLower();
                        if (optionSelected4.Equals("y"))
                        {
                            int newproductQuantity = productQuantity - quantity3;
                            Console.WriteLine("You buy" + quantity3);
                            Console.WriteLine("Remaining stock is " + newproductQuantity);
                        }
                        else if (optionSelected4.Equals("n"))
                        {
                            Console.WriteLine("");
                            onlineShopping();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                            Console.WriteLine("Restarting...");
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);

                            }
                            onlineShopping();
                        }
                        break;
                    default: Console.WriteLine("invalid option");
                        Console.WriteLine("Restarting...");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);

                        }
                        onlineShopping();
                        break;
                }




            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                login up = new login();
                up.loginMethod();

                first pers = new first();
                pers.startingPoint();









            }




        }
}

    





