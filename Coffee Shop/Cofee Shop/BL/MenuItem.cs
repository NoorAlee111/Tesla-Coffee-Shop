using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop.CofeeShoBl;
using Cofee_Shop.CoffeeShopUI;
using Cofee_Shop.CoffeeShopDl; 

namespace Cofee_Shop.BL
{
    class MenuItem
    {
        public string ItemName;
        public string ItemType;
        public int ItemPrice;
        public MenuItem(string ItemName,string ItemType,int ItemPrice)
        {
            this.ItemName = ItemName;
            this.ItemType = ItemType;
            this.ItemPrice = ItemPrice;
        }
        public MenuItem()
        {
       
        }
    }
}
