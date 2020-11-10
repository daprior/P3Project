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
    /// Interaction logic for AdminMenuView.xaml
    /// </summary>
    public partial class AdminMenuView : UserControl
    {
        public AdminMenuView()
        {
            InitializeComponent();

            gridview_data();
            
        }

        private void AdminMenuView_Load(object sender, EventArgs e)
        {
            gridview_data();
        }

        private void gridview_data()
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand("select name,price from menu", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            dtGrid.DataContext = dt;
        }

        private void AddToMenu_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "insert into menu (name, price) values('" + this.txtFoodName.Text + "','" + this.txtPrice.Text + "') ;";

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

            connection.Close();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "delete from menu where name='" + this.txtFoodName.Text + "';";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
              //  MessageBox.Show("Deleted");

                gridview_data();

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "update menu set name= '" + this.txtFoodName.Text + "',price= '" + this.txtPrice.Text + "' where name='" + this.txtFoodName.Text + "';";

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
               // MessageBox.Show("Updated");

                gridview_data();

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        }

    }
}
