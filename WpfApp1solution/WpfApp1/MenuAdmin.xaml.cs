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
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Navigation;
using System.IO;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        public MenuAdmin()
        {
            InitializeComponent();

        }


        private void btnMenu_Click(object sender, RoutedEventArgs e)   // Skifter til menu view
        {
            DataContext = new MenuViewModel();
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)   // Skifter til table view 
        {
            DataContext = new TableViewModel();
        }


        private void BtnExit_Click(object sender, RoutedEventArgs e)  // lukker program
        {
            MenuAdmin newWindow = new MenuAdmin();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

    }
}
