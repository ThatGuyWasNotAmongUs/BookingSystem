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

namespace WesAlipio.BookingSystem.Windows.Reservations
{
    /// <summary>
    /// Interaction logic for ReservationsList.xaml
    /// </summary>
    public partial class ReservationsList : Window
    {
        private string sortBy = "arrival";
        private string sortOrder = "asc";
        private string keyword = "";
        private int pageSize;
        private int pageIndex = 1;
        private long pageCount;
        public ReservationsList()


        {
            InitializeComponent();
            cboSortBy.ItemsSource = new List<string>() { "Arrival", "Departure" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };
            showData();
        }

        private void showData()
        {
            var customers = ReservationBLL.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);

            dgReservations.ItemsSource = customers.Items;
            pageCount = customers.PageCount;
        }

        private void txtPageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
            }

            showData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                keyword = txtSearch.Text;
                showData();
            }
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "ascending")
            {
                sortOrder = "asc";
            }
            else
            {
                sortOrder = "desc";
            }
            showData();
        }

        private void cboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sortBy = cboSortBy.SelectedValue.ToString();
            showData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ReservationAdd addWindow = new ReservationAdd(this);
            addWindow.Show();
        }
    }
}

