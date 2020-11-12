using MySql.Data.MySqlClient;
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
using WpfApp1.Views;

namespace WpfApp1
{
    
    /// <summary>
    /// Interaction logic for KitchenForm.xaml
    /// </summary>
    public partial class KitchenForm : Window
    {
        

        public KitchenForm()
        {
            DataContext = new KitchenViewModel();

            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {


            var button = sender as Button;

            var viewmodel = button.DataContext as OrderViewModel;

            viewmodel.RemoveOrder();

            var kitchenviewmodel = DataContext as KitchenViewModel;

            kitchenviewmodel.UpdateOrders();
        }
    }
}
