using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop.BL;
using Cofee_Shop.CoffeeShopUI;
using Cofee_Shop.CoffeeShopDl; 

namespace Cofee_Shop.CofeeShoBl
{
    class CoffeeShop
    {
        public string ShopName;
        public static List<MenuItem> menu = new List<MenuItem>();
        public List<string> orders = new List<string>();
        public CoffeeShop(string ShopName)
        {
            this.ShopName = ShopName;
        }
       
       
        public List<string> ListOrders(CoffeeShop c)
        {
            if (!(c.orders.Contains(null)))
            {
                return c.orders;
            }
            return null;
        }
        public static int dueAmount(CoffeeShop c)
        {
            int dueamount = 0;
            if (!(c.orders.Contains(null)))
            {
                foreach (string order in c.orders)
                {
                    foreach (MenuItem item in menu)
                    {
                        if (order == item.ItemName)
                        {
                            dueamount = dueamount + item.ItemPrice;
                        }
                    }
                }
              
            }
            return dueamount;

        }
        
        public static string CheapestItem()
        {
            List<MenuItem> sortedlist = new List<MenuItem>();
            sortedlist = CoffeeShopDL.sortItembyPrice();
            string CheapestItemName = sortedlist[0].ItemName;
            return CheapestItemName;
        }
        
        public bool fulfillorder()
        {
            if(orders.Count==0)
            {
                return false;
            }
            return true;
        }
       
    }
}
