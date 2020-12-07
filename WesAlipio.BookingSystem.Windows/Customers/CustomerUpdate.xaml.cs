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
using WesAlipio.BookingSystem.Windows.Models;
using WesAlipio.BookingSystem.Windows.BLL;

namespace WesAlipio.BookingSystem.Windows.Customers
{
    /// <summary>
    /// Interaction logic for CustomerUpdate.xaml
    /// </summary>
    public partial class CustomerUpdate : Window
    {
        CustomerList myParentWindow = new CustomerList();
        private Customer thisCustomer;
        public CustomerUpdate(Customer customer,CustomerList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
            thisCustomer = customer;

            txtFirstName.Text = thisCustomer.FirstName;
            txtLastName.Text = thisCustomer.LastName;
            txtHomeAddress.Text = thisCustomer.HomeAddress;
            txtMobileNumber.Text = thisCustomer.ContactNumber;
            txtEmailAddress.Text = thisCustomer.EmailAddress;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var op = CustomerBLL.Update(new Customer()
            {
                Id = thisCustomer.Id,
                EmailAddress = txtEmailAddress.Text,
                ContactNumber = txtMobileNumber.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                HomeAddress = txtHomeAddress.Text
            });

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("Employee is successfully updated");
            }

            myParentWindow.showData();
            this.Close();
        }

    }
}
