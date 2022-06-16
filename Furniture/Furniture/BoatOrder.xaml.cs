using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
    /// Логика взаимодействия для BoatOrder.xaml
    /// </summary>
    public partial class BoatOrder : Window
    {
        private IEnumerable boatItemList;
        private Order order { get; set; }
        private DataContext context { get; set; }

        public BoatOrder()
        {
            InitializeComponent();
            context = new DataContext();
            order = new Order();
            context.Order.Add(order);
            order.OrderBoat = new List<OrderBoat>();
            order.Amount = 0;
            //order.Boat = new List<Boat>();
            order.DateTime = DateTime.Now;
            UpdateData();
        }

        public void UpdateData()
        {
            context.SaveChanges();
            List<TypeBoat> DatabaseCategories = context.TypeBoats.Include(type => type.Boat).ToList();
            TypeItemList.ItemsSource = DatabaseCategories;
            boatItemList = BoatsItemList.ItemsSource;
            BoatsItemList.ItemsSource = null;
            BoatsItemList.ItemsSource = boatItemList;
            OrderBoatItemList.ItemsSource = null;
            OrderBoatItemList.ItemsSource = order.OrderBoat;
            Amount.Content = order.Amount;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boat boat = (Boat)BoatsItemList.SelectedItem;
            if (boat != null)
            {
                int quantity = Convert.ToInt32(QuantitySlider.Value);
                int amountForProduct = quantity * boat.Price;

                order.OrderBoat.Add(new OrderBoat { Boat = boat, Quantity = quantity, Amount = amountForProduct });
                order.Amount += amountForProduct;
            }
            UpdateData();

        }
        private void TypeItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TypeBoat typeBoat = (TypeBoat)e.AddedItems[0];
            BoatsItemList.ItemsSource = typeBoat.Boat;
        }

        private void ProductsItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Boat boat = (Boat)e.AddedItems[0];
            }
        }

        private void QuantitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Boat boat = (Boat)BoatsItemList.SelectedItem;
            if (boat != null)
                AmountForProduct.Content = e.NewValue * boat.Price;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OrderBoat receiptProduct = (OrderBoat)OrderBoatItemList.SelectedItem;
            order.Amount -= receiptProduct.Amount;
            order.OrderBoat.Remove(receiptProduct);
            UpdateData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            context.Order.Remove(order);
            UpdateData();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
