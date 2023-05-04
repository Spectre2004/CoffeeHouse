using CoffeeHouse.DB;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static CoffeeHouse.ClassHelper.EFClass;
using CoffeeHouse.Windows.General;
using CoffeeHouse.Windows.DIrector;
using CoffeeHouse.ClassHelper;

using System.Runtime.Remoting.Contexts;
using System;

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

            prodList = EFClass.Context.Product.ToList();

            LvProductList.ItemsSource = prodList;
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
            SetDiscount(new DateTime(2023, 06, 22));
            Basket basket = new Basket();
            basket.Show();
            Close();
        }

        private void addBasket_Click(object sender, RoutedEventArgs e)
        {
            bool seek = true;
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            DB.Product selectedProduct = button.DataContext as DB.Product;

            if (selectedProduct != null)
            {
                for (int i = 0; i < ProdBasket.BasketProducts.Count; i++)
                {
                    if (ProdBasket.BasketProducts[i] == selectedProduct)
                    {
                        ProdBasket.BasketProducts[i].Quantity++;
                        seek = false;
                    }
                }
                if (seek)
                {
                    selectedProduct.Quantity = 1;
                    ProdBasket.BasketProducts.Add(selectedProduct);
                }
            }

            MessageBox.Show("Товар добавлен в корзину");

        }
        public void SetDiscount(DateTime dateTime)
        {
            int count = 0;
            DateTime dateTimeCheck;
            dateTimeCheck = new DateTime(dateTime.Year, dateTime.Month, 1);
            while (dateTimeCheck != dateTime.AddDays(1))
            {
                if (dateTimeCheck.DayOfWeek == DayOfWeek.Thursday)
                {
                    count++;
                    if (count == 4 && dateTime.Day == dateTimeCheck.Day)
                    {
                        ClassHelper.Discount.IsDiscount = true;
                    }
                }
                dateTimeCheck = dateTimeCheck.AddDays(1);
            }
        }
    }
}
