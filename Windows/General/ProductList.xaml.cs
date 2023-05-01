using CoffeeHouse.DB;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


using static CoffeeHouse.ClassHelper.EFClass;

namespace CoffeeHouse.Windows.General
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Window
    {
        public ProductList()
        {
            InitializeComponent();

            GetProduct();

        }
        private void GetProduct()
        {
            List<Product> prodList = new List<Product>();

            prodList = Context.Product.ToList();

            LvProductList.ItemsSource = prodList;
        }
    }
}
