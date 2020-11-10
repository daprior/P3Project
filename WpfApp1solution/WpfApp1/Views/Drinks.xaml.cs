using System;
using System.Collections.Generic;
using System.Data;
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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Renci.SshNet.Security.Cryptography.Ciphers;
using WpfApp1;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl
    {
        public Drinks()
        {

            InitializeComponent();

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("Select * from menu", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            adapter.Dispose();
            con.Close();
            dataGrid.ItemsSource = dt.DefaultView;

            

        }




        private void btnView_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                String Name = dataRowView[1].ToString();
                String Price = dataRowView[2].ToString();



                MessageBox.Show("You Clicked : " + Name + "\r\nPrice : " + Price);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {

            DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
            dataRowView[1].ToString();
            dataRowView[2].ToString();

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "insert into projectgroup.order (itemname,itemprice) values ('" + dataRowView[1].ToString() + "','" + dataRowView[2].ToString() + "') ;";
            MySqlDataAdapter adapter;


            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;

            try
            {

                connection.Open();
                myReader = cmd.ExecuteReader();
                // MessageBox.Show("Saved");

                (DataContext as DrinksViewModel).Parent.Gridvieworder_Data();

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            connection.Close();

            
        }
    }
}
