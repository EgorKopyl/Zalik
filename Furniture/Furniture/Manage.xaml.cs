using Microsoft.EntityFrameworkCore;
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

namespace boat
{
    /// <summary>
    /// Логика взаимодействия для Manage.xaml
    /// </summary>
    public partial class Manage : Window
    {
        private DataContext context { get; set; }
        public Manage()
        {
            context = new DataContext();
            InitializeComponent();
            UpdateData();
        }
        public void UpdateData()
        {
            List<Boat> DatabaseBoat = context.Boats.Include(product =>
            product.TypeBoat).ToList();
            BoatItemList.ItemsSource = DatabaseBoat;
            List<TypeBoat> DatabaseTypeBoat = context.TypeBoats.ToList();
            TypeBoatItemList.ItemsSource = DatabaseTypeBoat;
            TypeBoatComboBox.ItemsSource = DatabaseTypeBoat;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            context.TypeBoats.Add(new TypeBoat
            {
                Name = NameTextBox.Text
            });
            context.SaveChanges();
            UpdateData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TypeBoat selectedTypeBoat = TypeBoatItemList.SelectedItem as TypeBoat;
            selectedTypeBoat.Name = NameTextBox.Text;
            context.SaveChanges();
            UpdateData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {           
                if (TypeBoatItemList.SelectedItem is TypeBoat selectedTypeBoat)
                {
                    context.TypeBoats.Remove(selectedTypeBoat);
                    context.SaveChanges();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Select some row", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                }            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var price = PriceTextBox.Text;
            int.TryParse(price, out int intPrice);
            context.Boats.Add(new Boat
            {
                Name = BoatNameTextBox.Text,
                Price = intPrice,
                TypeBoat = TypeBoatComboBox.SelectedItem as TypeBoat
            });
            context.SaveChanges();
            UpdateData();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (BoatItemList.SelectedItem is Boat selectedBoat)
            {
                var price = PriceTextBox.Text;
                int.TryParse(price, out int intPrice);
                selectedBoat.Name = BoatNameTextBox.Text;
                selectedBoat.Price = intPrice;
                selectedBoat.TypeBoat = TypeBoatComboBox.SelectedItem as TypeBoat;
                context.SaveChanges();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Select some row", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (BoatItemList.SelectedItem is Boat selectedBoat)
            {
                context.Boats.Remove(selectedBoat);
                context.SaveChanges();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Select some row", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }
    }
}
