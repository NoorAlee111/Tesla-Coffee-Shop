using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop.CofeeShoBl;
using Cofee_Shop.CoffeeShopUI;
using Cofee_Shop.BL;

namespace Cofee_Shop.CoffeeShopDl
{
    class CoffeeShopDL
    {
        public static void AddMenuItemtoList(MenuItem item)
        {
            CoffeeShop.menu.Add(item);
        }
        public static bool AddOrder(string order, CoffeeShop c)
        {
            bool flag = false;
            foreach (MenuItem item in CoffeeShop.menu)
            {
                if (order == item.ItemName)
                {
                    c.orders.Add(order);
                    flag = true;
                }
            }
            return flag;
        }
        public static List<MenuItem> sortItembyPrice()
        {
            List<MenuItem> sortedlist = new List<MenuItem>();

            sortedlist =CoffeeShop.menu.OrderBy(o => o.ItemPrice).ToList();
            return sortedlist;
        }
        public static List<string> drinksOnly()
        {
            List<string> drinks = new List<string>();
            foreach (MenuItem item in CoffeeShop.menu)
            {
                if (item.ItemType == "Drink")
                {
                    drinks.Add(item.ItemName);
                }
            }
            return drinks;
        }
        public static List<string> FoodOnly()
        {
            List<string> Food = new List<string>();
            foreach (MenuItem item in CoffeeShop.menu)
            {
                if (item.ItemType == "Food")
                {
                    Food.Add(item.ItemName);
                }
            }
            return Food;
        }
    }
}
