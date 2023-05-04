using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeHouse.ClassHelper
{
    internal class ProdBasket
    {
        public static ObservableCollection<DB.Product> BasketProducts = new ObservableCollection<DB.Product>();
    }
}
