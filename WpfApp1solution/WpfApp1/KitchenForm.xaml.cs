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
            InitializeComponent();

            OrderControl.Content = new FirstOrderViewModel(DataContext as KitchenForm);
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            TableMenuForm tablemenuform = new TableMenuForm();
            this.Close();
            tablemenuform.Show();
        }
    }
}
