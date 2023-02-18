using CoffeeHouse.DB;
using Microsoft.Win32;
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
using CoffeeHouse.Windows;
using System.IO;

namespace CoffeeHouse.Windows.General
{
    /// <summary>
    /// Логика взаимодействия для AddEditProd.xaml
    /// </summary>
    public partial class AddEditProd : Window
    {
        private string pathPhoto = null;
        public AddEditProd()
        {
            InitializeComponent();

            CmbCategoryProd.ItemsSource = Context.Category.ToList();
            CmbCategoryProd.SelectedIndex = 0;
            CmbCategoryProd.DisplayMemberPath = "CategoryName";
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                pathPhoto = openFileDialog.FileName;
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }

            
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            Category category = new Category();
            if (string.IsNullOrWhiteSpace(TbNameProd.Text) || string.IsNullOrWhiteSpace(TbDescription.Text) || string.IsNullOrWhiteSpace(TbPrice.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }
            product.ProdName = TbNameProd.Text;
            product.Description = TbDescription.Text;
            product.IdCategory = (CmbCategoryProd.SelectedItem as Category).IdCategory;
            if (pathPhoto != null)
            {
                product.ProdImage = File.ReadAllBytes(pathPhoto);
            }
            else
            {
                MessageBox.Show("Выберете изображение.");
                return;
            }
            product.Price = Convert.ToDecimal(TbPrice.Text);


            Context.Product.Add(product);

            Context.SaveChanges();
            MessageBox.Show("OK");
        }
    }
}
