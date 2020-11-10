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
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml prut
    /// </summary>
    public partial class LoginScreen : Window
    {


        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server = localhost; user id = root; password = dtn38hyj; database = projectgroup");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from users where Username ='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                MySqlDataAdapter sda1 = new MySqlDataAdapter("Select Role from users where Username ='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if(dt1.Rows[0][0].ToString() == "admin")
                {

                    MenuAdmin ma = new MenuAdmin();
                    ma.Show();
                    this.Hide();

                }
                if (dt1.Rows[0][0].ToString() == "kitchen")
                {
                    KitchenForm ma1 = new KitchenForm();
                    ma1.Show();
                    this.Hide();
                }
                if (dt1.Rows[0][0].ToString() == "table")
                {
                    TableMenuForm ma2 = new TableMenuForm();
                    ma2.DataContext = new TableMenuViewModel();
                    ma2.Show();
                    this.Hide();
                }
            }

        }
    }
}
