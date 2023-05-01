using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;
using CoffeeHouse.ClassHelper;


namespace CoffeeHouse.Windows.DIrector
{
    /// <summary>
    /// Interaction logic for SalesList.xaml
    /// </summary>
    public partial class SalesList : Window
    {
        public SalesList()
        {
            InitializeComponent();
            GetSaleList();
        }

        private void GetSaleList()
        {
            dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList();
        }
        private void GetSaleList(string criterion)
        {
            switch (criterion)
            {

                case "Работник":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.EmployeerName);
                    break;

                case "Клиент":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.ClientName);
                    break;

                case "Время продажи":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.SaleDateTime);
                    break;

                case "Продукт":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.ProductName);
                    break;

                case "Количество":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.Quantity);
                    break;

                case "Цена":
                    dgSaleList.ItemsSource = EFClass.Context.SaleList.ToList()
                        .OrderBy(i => i.FullPrice);
                    break;
                default: break;
            }
        }

        private void cmbSort_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string criterion = cmbSort.SelectedValue.ToString();
            criterion = criterion.Substring(38, criterion.Length - 38);
            GetSaleList(criterion);
        }

        private void dpStd_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            dpStd.Text = DateTime.Now.ToString();
        }
    }
}
