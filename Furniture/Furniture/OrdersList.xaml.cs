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
    /// Логика взаимодействия для OrdersList.xaml
    /// </summary>
    public partial class OrdersList : Window
    {
        private DataContext context { get; set; }
        public OrdersList()
        {
            context = new DataContext();
            InitializeComponent();
            UpdateData();
        }       

        public void Window_Closed(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            List<Order> DatabaseReceipts = context.Order.Include(order => order.Boats).Include(order => order.OrderBoat).ToList();
            OrderItemList.ItemsSource = DatabaseReceipts;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (OrderItemList.SelectedItem is Order selectedReceipt)
            {
                context.Order.Remove(selectedReceipt);
                context.SaveChanges();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Select some row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void OrderItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Order order = (Order)e.AddedItems[0];
                OrderBoatItemList.ItemsSource = order.OrderBoat;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BoatOrder boatOrder = new BoatOrder();
            boatOrder.Closed += Window_Closed;
            boatOrder.ShowDialog();
        }
    }
}
