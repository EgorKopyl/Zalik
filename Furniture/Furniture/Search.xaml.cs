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
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        private DataContext context { get; set; }
        public Search()
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
            SerchComboBox.ItemsSource = DatabaseTypeBoat;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Boat> DatabaseBoat = context.Boats.Include(product =>
            product.TypeBoat).ToList();
            List<Boat> list = new List<Boat>();
            DatabaseBoat.ForEach((x) => {
                if (SerchComboBox.SelectedItem.Equals(x.TypeBoat))
                {
                    list.Add(x);
                }
            });
          
            BoatItemList.ItemsSource = list;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Boat> DatabaseBoat = context.Boats.Include(product =>
            product.TypeBoat).ToList();
            List<Boat> list = new List<Boat>();
            DatabaseBoat.ForEach((x) => {
                if (x.Name.Contains(SerchText.Text))
                {
                    list.Add(x);
                }
            });
            BoatItemList.ItemsSource = list;
        }

    }
}
