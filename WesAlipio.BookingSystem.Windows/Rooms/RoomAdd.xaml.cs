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
using WesAlipio.BookingSystem.Windows.BLL;
using WesAlipio.BookingSystem.Windows.Models;

namespace WesAlipio.BookingSystem.Windows.Rooms
{
    /// <summary>
    /// Interaction logic for RoomAdd.xaml
    /// </summary>
    public partial class RoomAdd : Window
    {
        RoomList myParentWindow = new RoomList();

        public RoomAdd(RoomList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            var op = RoomBLL.Add(new Room()
            { 
               Availaibility = Models.Enums.Availability.Available,
               RoomNumber = txtRoomNumber.Text,
               RoomDescription = txtDesc.Text,
               Occupants = txtOccupants.Text,
               Pricing = int.Parse(txtPrice.Text)

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Customer is successfully added to table");
            }

            myParentWindow.showData();
            this.Close();
        }
    }
}
