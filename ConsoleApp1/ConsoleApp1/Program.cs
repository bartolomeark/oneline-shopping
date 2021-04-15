using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string productName = "Ballpen";
            string productCategory = "School Supplies";
            DateTime addedDate = new DateTime(2021, 04, 06);
            int stockLimit = 500;
            int productQuantity = 500;


            string productName1 = "Shorts";
            string productCategory1 = "Trousers and Shorts";
            DateTime addedDate1 = new DateTime(2021, 04, 06);
            int stockLimit1 = 300;
            int productQuantity1 = 259;


            string productName2 = "Tshirt";
            string productCategory2 = "Shirts";
            DateTime addedDate2 = new DateTime(2021, 04, 06);
            int stockLimit2 = 300;
            int productQuantity2 = 201;


            string productName3 = "Bucket hat";
            string productCategory3 = "Cap";
            DateTime addedDate3 = new DateTime(2021, 04, 06);
            int stockLimit3 = 100;
            int productQuantity3 = 78;

            Console.WriteLine("Welcome to Online Shopping System!");
            Console.WriteLine("Available Product: 1." + productName);
            Console.WriteLine("Available Product: 2." + productName1);
            Console.WriteLine("Available Product: 3." + productName2);
            Console.WriteLine("Available Product: 4." + productName3);

            Console.Write("what product you want to buy: ");
            Console.WriteLine("Product: 1, 2, 3, or 4?");
            int optionSelected = Convert.ToInt32(Console.ReadLine());
            try {
                switch (optionSelected)
                {
                    case 1: Console.WriteLine(productName); break;
                    case 2: Console.WriteLine(productName1); break;
                    case 3: Console.WriteLine(productName2); break;
                    case 4: Console.WriteLine(productName3); break;
                    default: Console.WriteLine("invalid option"); break;
                }

            } catch {
                Console.Write("Type q if you want to view quantity or b if you want to buy: ");
                string optionSelected1 = Console.ReadLine().ToLower();
                if (optionSelected.Equals("q"))
                {

                    Console.WriteLine(productQuantity);
                }
                else if (optionSelected1.Equals("2"))
                {
                    Console.WriteLine(productQuantity1);
                }
                else if (optionSelected1.Equals("3"))
                {
                    Console.WriteLine(productQuantity2);
                }
                else if (optionSelected1.Equals("3"))
                {
                    Console.WriteLine(productQuantity3);
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");

                }


            }
            finally { 
                
                else if (optionSelected.Equals("b"))
                {
                    Console.WriteLine("How many would you like to buy?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    productQuantity -= quantity;
                    //productQuantity = productQuantity - quantity
                }
                else
                {
                    Console.WriteLine("Error: Invalid option");
                } /*
                    Console.WriteLine("what item you want to view. Type 1 for ballpen, Type 2 for shorts, Type 3 for tshirt, Type 4 for hats");
                    string optionSelected1 = Console.ReadLine().ToLower();
                    if (optionSelected.Equals("1"))
                    {*/
            }



        }
    }
}


