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

namespace CoffeeHouse.Windows.Client
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void tbLogIn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLogin.Text))
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }

            var authUser = Context.Account.ToList().Where(i => i.Login == TbLogin.Text).FirstOrDefault();

            if (authUser != null) 
            {
                MessageBox.Show("Логин занят");
                return;
            }

            DB.Account account = new DB.Account();
            account.FirstName = TbFio.Text.Split(' ')[0];
            account.Surname = TbFio.Text.Split(' ')[1];
            account.Patronymic = TbFio.Text.Split(' ')[2];
            account.Login = TbLogin.Text;
            account.Email = TbEmail.Text;
            account.Password = TbPassword.Text;
            account.IdRole = 1;

            Context.Account.Add(account);
            MessageBox.Show("Успех");
            Context.SaveChanges();  

        }
    }
}
