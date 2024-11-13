using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop.BL;
using Cofee_Shop.CofeeShoBl;
using Cofee_Shop.CoffeeShopUI;
using Cofee_Shop.CoffeeShopDl;


namespace Cofee_Shop.CoffeeShopUI
{
    class CoffeeShoUI
    {
        public static void DisplayCheapestItem(string item)
        {
            Console.WriteLine("Cheapest Item:{0}", item);
        }
        static public MenuItem GetInputFromConsole()
        {
            int itemprice = 0;
            string itemname = "";
            string itemtype = "";
            Console.Write("Enter Item Name:");
            itemname = Console.ReadLine();
            Console.Write("Enter Item Type:");
            itemtype = Console.ReadLine();
            Console.Write("Enter Item Price:");
            itemprice = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(itemname, itemtype, itemprice);
            return item;
        }
        static public int Menu()
        {
            int op = 0;
            Console.WriteLine("________-Welcome to the Tesha’s Coffee Shop_______");

            Console.WriteLine("1:Add a Menu item");
            Console.WriteLine("2:View the Cheapest Item in the menu");
            Console.WriteLine("3:View the Drink’s Menu");
            Console.WriteLine("4:View the Food’s Menu");
            Console.WriteLine("5:Add Order");
            Console.WriteLine("6:Fulfill the Order");
            Console.WriteLine("7:View the Orders’s List");
            Console.WriteLine("8:Total Payable Amount");
            Console.WriteLine("9:Exit");
            Console.WriteLine("Enter your option:");
            op = int.Parse(Console.ReadLine());
            return op;

        }
        static public void DisplayFood(List<string> Food)
        {
            foreach (string item in Food)
            {
                Console.WriteLine(item);
            }
        }
        static public void DisplayDrinks(List<string> Drinks)
        {
            foreach (string item in Drinks)
            {
                Console.WriteLine(item);
            }
        }
        static public string getorder()
        {
            Console.Write("Enter the Item Name:");
            string order = Console.ReadLine();
            return order;
        }
        static public void OrderConfirmation(bool flag)
        {
            if (flag == true)
            {
                Console.WriteLine("Order is added...");
            }
            else if (flag == false)
            {
                Console.WriteLine("This item is currently unavailable!");
            }
        }
        public static  void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayOrders(List<string> orders)
        {
            foreach (string order in orders)
            {
                Console.WriteLine(order);
            }
        }
        public static void DisplayDueAmount(int dueamount)
        {
            Console.WriteLine("Total Payable amount:" + dueamount);
        }
        public static void FulfillOrder(bool flag, CoffeeShop Customer)
        {
            if (flag == false)
            {
                Console.WriteLine("All Orders have been fulfilled..");
            }
            else if (flag == true)
            {

                foreach (string order in Customer.orders)
                {
                    Console.WriteLine("The {0} is ready!", order);
                    Customer.orders.Remove(order);
                    if (Customer.orders.Count == 0)
                    {
                        Console.WriteLine("All Orders have been fulfilled..");
                        break;
                    }
                }


            }
        }
    }
}
