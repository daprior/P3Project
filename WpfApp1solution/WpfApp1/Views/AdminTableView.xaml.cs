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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for AdminTableView.xaml
    /// </summary>
    public partial class AdminTableView : UserControl
    {
        public AdminTableView()
        {
            InitializeComponent();

            gridview_data();
        }

        private void AdminTableView_Load(object sender, EventArgs e)
        {
            gridview_data();
        }

        private void gridview_data()
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand("select Username,Password from users", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            dtGrid.DataContext = dt;
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "delete from users where Username='" + this.txtUsername.Text + "';";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                //MessageBox.Show("Deleted");

                gridview_data();

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "insert into users (Username, Password, Role) values('" + this.txtUsername.Text + "','" + this.txtUserPassword.Text + "','" + this.txtUserRole.Text + "') ;";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                //MessageBox.Show("Saved");


                gridview_data();

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
