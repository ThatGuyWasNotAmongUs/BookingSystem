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

namespace WesAlipio.BookingSystem.Windows.Reservations
{
    /// <summary>
    /// Interaction logic for ReservationAdd.xaml
    /// </summary>
    public partial class ReservationAdd : Window
    {
        ReservationsList myParentWindow = new ReservationsList();
        public ReservationAdd(ReservationsList parentWindow)
        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }
    }
}
