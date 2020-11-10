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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TableMenuForm.xaml
    /// </summary>
    public partial class TableMenuForm : Window
    {

        KitchenForm kitchenform = new KitchenForm();

        public TableMenuForm()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new FoodViewModel((DataContext as TableMenuViewModel));
        }

        private void btnDrink_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DrinksViewModel((DataContext as TableMenuViewModel));
        }

        public void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;


            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = " delete from projectgroup.order where id= '" + dataRowView[0].ToString() + "' AND itemname= '" + dataRowView[1].ToString() + "' AND itemprice= '" + dataRowView[2].ToString() + "' ;";
            MySqlDataAdapter adapter;

            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;

            try
            {

                connection.Open();
                myReader = cmd.ExecuteReader();
                //MessageBox.Show("Deleted");

                refresh();

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

        private void refresh()
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("Select id,itemname,itemprice from projectgroup.order", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            adapter.Dispose();
            con.Close();
            orderGrid.ItemsSource = dt.DefaultView;
        }




        private void CallWaiterButton_Click(object sender, RoutedEventArgs e)
        {

            kitchenform.contentControl.Content = new CallWaiterViewModel((DataContext as KitchenForm));

            //contentControl.Content = new CallWaiterViewModel((DataContext as KitchenForm));
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            kitchenform.Show();
        }

        private void Proceed_Click(object sender, RoutedEventArgs e)
        {

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "insert into projectgroup.completedorder (itemname) select (itemname) from projectgroup.order ;";


            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;

            try
            {

                connection.Open();
                myReader = cmd.ExecuteReader();
                // MessageBox.Show("Saved");

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Tuncate();

            connection.Close();

        }

        private void Tuncate()
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";
            string Query = "TRUNCATE TABLE projectgroup.order";


            MySqlConnection connection = new MySqlConnection(connectionstring);

            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;

            try
            {

                connection.Open();
                myReader = cmd.ExecuteReader();
                // MessageBox.Show("Saved");

                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            connection.Close();

            refresh();
        }
    }
}
