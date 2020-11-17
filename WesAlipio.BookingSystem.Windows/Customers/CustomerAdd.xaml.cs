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


namespace WesAlipio.BookingSystem.Windows.Customers
{
    /// <summary>
    /// Interaction logic for CustomerAdd.xaml
    /// </summary>
    public partial class CustomerAdd : Window
    {
        CustomerList myParentWindow = new CustomerList();
        public CustomerAdd(CustomerList parentWindow)
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
            var op = CustomerBLL.Add(new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                EmailAddress = txtEmailAddress.Text,
                ContactNumber = txtMobileNumber.Text,
                HomeAddress = txtHomeAddress.Text

            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Customer is successfully added to table");
            }
        }
    }
}
