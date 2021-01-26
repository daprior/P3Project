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
using WpfApp1.ViewModels;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.BC;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp1.Models;
using System.IO;
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TableMenuForm.xaml
    /// </summary>
    public partial class TableMenuForm : Window
    {
        private bool _IsOn;
        public bool IsOn
        {
            get
            {
                return _IsOn;
            }
            set
            {
                _IsOn = value;
                CallWaiterButton.Content = _IsOn ? "Waiter called" : "Call waiter";
            }
        }
        public TableMenuForm()
        {
            InitializeComponent();
        }
        public void btnRemove_Click(object sender, RoutedEventArgs e) // Fjerner noget fra ordren.
        {
            var orderitem = (sender as Button).Tag as OrderItem;

            var viewmodel = DataContext as TableMenuViewModel;
            viewmodel.OrderTable.Remove(orderitem);
        }
        private void CallWaiterButton_Click(object sender, RoutedEventArgs e) // metode til at kalde waiter, virker ikke rigtigt.
        {
            IsOn = !IsOn;
        }
        private void Show_Click(object sender, RoutedEventArgs e)  // bruges ikke. Men viser tabbellen. 
        {

            KitchenForm kitchenform = new KitchenForm();

            kitchenform.Show();
        }
        private void Proceed_Click(object sender, RoutedEventArgs e) // når brugeren trykker proceed, bliver den sendt vedere af metoden SubmidORder() der sætter det ind i databasen, så køkkenet kan se ordren. 
        {
            var viewmodel = DataContext as TableMenuViewModel;
            viewmodel.SubmitOrder(); // metode fra connection.
        }
        private void btnAddToOrder_Click(object sender, RoutedEventArgs e) // adder til menu table som er et dictionary der holder ordren indtil den er sendt videre.
        {
            var button = sender as Button;

            var datarowview = button.Tag as DataRowView;

            var viewmodel = DataContext as TableMenuViewModel;
            viewmodel.OrderTable.Add(new OrderItem { ID=(int)datarowview["id"] , Name=datarowview["name"] as string , Price = datarowview["price"] as string });
        }
    }
}
