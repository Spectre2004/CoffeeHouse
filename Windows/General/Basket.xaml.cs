using CoffeeHouse.ClassHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static CoffeeHouse.ClassHelper.EFClass;
using static CoffeeHouse.ClassHelper.ProdBasket;

namespace CoffeeHouse.Windows.General
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public Basket()
        {
            InitializeComponent();

            GetProductList();
        }


        void GetProductList()
        {
            LvProductList.ItemsSource = BasketProducts.ToList();
            tbPrice.Text = "0";
            if (Discount.IsDiscount)
            {
                foreach (var item in BasketProducts)
                {
                    tbPrice.Text = Convert.ToString(Convert.ToDouble(tbPrice.Text) + Convert.ToDouble(item.Price) * item.Quantity);
                }
                tbPrice.Text = Convert.ToString(Convert.ToDouble(tbPrice.Text) - (Convert.ToDouble(tbPrice.Text) * Discount.DiscountSize));
                tbPrice.Text += $" со скидкой {Discount.DiscountSize}";
            }
            else
            {
                foreach (var item in BasketProducts)
                {
                    tbPrice.Text = Convert.ToString(Convert.ToDouble(tbPrice.Text) + Convert.ToDouble(item.Price) * item.Quantity);
                }
            }
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ProductList productList= new ProductList();
            productList.Show();
            Close();
        }
    }
}
