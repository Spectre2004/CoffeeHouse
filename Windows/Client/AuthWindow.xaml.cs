using CoffeeHouse.DB;
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
using CoffeeHouse.Windows.General;
using CoffeeHouse.Windows.DIrector;

namespace CoffeeHouse.Windows.Client
{

    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        
        public void tbRegistration_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var autherUser = Context.Account.ToList().
                Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();
            if (autherUser != null)
            {
                if (autherUser.IdRole == 1)
                {
                    MessageBox.Show("Успех");
                    ProductList productList = new ProductList();
                    productList.Show();
                    Close();
                }
                else if (autherUser.IdRole == 2)
                {
                    MessageBox.Show("Успех, вы вошли как директор");
                    DirectorControllWindow directorsStatistic = new DirectorControllWindow();
                    directorsStatistic.Show();
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
