using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop.BL;
using Cofee_Shop.CofeeShoBl;
using Cofee_Shop.CoffeeShopUI;
using Cofee_Shop.CoffeeShopDl;

namespace Cofee_Shop
{
    class Program
    {

        static void Main(string[] args)
        {
            CoffeeShop Customer =new CoffeeShop("Teshla");
            int option = 0;
            while(true)
            {
                option = CoffeeShoUI.Menu();
                if(option==1)
                {
                    MenuItem item = new MenuItem();
                    item = CoffeeShoUI.GetInputFromConsole();
                    CoffeeShopDL.AddMenuItemtoList(item);
                }
                else if(option==2)
                {
                    string CheapestItemName = CoffeeShop.CheapestItem();
                    CoffeeShoUI.DisplayCheapestItem(CheapestItemName);
                }
                else if (option == 3)
                {
                    List<string> Drinks = new List<string>();
                    Drinks = CoffeeShopDL.drinksOnly();
                    CoffeeShoUI. DisplayDrinks(Drinks);
                }
                else if (option == 4)
                {
                    List<string> Food = new List<string>();
                    Food = CoffeeShopDL.FoodOnly();
                    CoffeeShoUI.DisplayFood(Food);

                }
                else if (option == 5)
                {
                    string order = CoffeeShoUI.getorder();
                    bool flag = CoffeeShopDL.AddOrder(order, Customer);
                    CoffeeShoUI.OrderConfirmation(flag);

                }
                else if (option == 6)
                {
                    bool flag = Customer.fulfillorder();
                    CoffeeShoUI.FulfillOrder(flag, Customer);
                }
                else if (option == 7)
                {
                    List<string> orders = new List<string>();
                    orders = Customer.ListOrders(Customer);
                    CoffeeShoUI.DisplayOrders(orders);
                }
                else if (option == 8)
                {
                    int dueamount = CoffeeShop.dueAmount(Customer);
                    CoffeeShoUI.DisplayDueAmount(dueamount);
                }
                else if (option == 9)
                {
                    break;
                }
                CoffeeShoUI.clearScreen();
            }
        }
        

        
       
        
        
       
       
       
       

        
    }
}
