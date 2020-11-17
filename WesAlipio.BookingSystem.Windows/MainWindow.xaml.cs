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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WesAlipio.BookingSystem.Windows.DAL;

namespace WesAlipio.BookingSystem.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // BookingDBContext context = new BookingDBContext();

            //var customer = context.Customers.FirstOrDefault();
            //if(customer != null)
            //{
             //   MessageBox.Show(customer.FirstName +" " + customer.LastName);
            //};
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            Customers.CustomerList CustomerWindow = new Customers.CustomerList();
            CustomerWindow.Show();
        }

        private void btnRooms_Click(object sender, RoutedEventArgs e)
        {
            Rooms.RoomList RoomWindow = new Rooms.RoomList();
            RoomWindow.Show();        
        }

        private void btnReservations_Click(object sender, RoutedEventArgs e)
        {
            Reservations.ReservationsList ReservationWindow = new Reservations.ReservationsList();
            ReservationWindow.Show();
        }
    }
}
