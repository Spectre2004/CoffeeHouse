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

namespace CoffeeHouse.Windows.DIrector
{
    /// <summary>
    /// Логика взаимодействия для DirectorsStatistic.xaml
    /// </summary>
    public partial class DirectorControllWindow : Window
    {
        public DirectorControllWindow()
        {
            InitializeComponent();
        }

        private void btnSaleList_Click(object sender, RoutedEventArgs e)
        {
            SalesList salesList = new SalesList();
            salesList.Show();
        }
    }
}
