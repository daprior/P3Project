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

            tableView();
        }


        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = project; User Id = root; Password = dtn38hyj;");

            string Query = "delete from project.users where (Username,Password,Role) = (@Username,@Password,@Role)";

            MySqlCommand command = new MySqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Username", txtUsername);
            command.Parameters.AddWithValue("@Password", txtUserPassword);
            command.Parameters.AddWithValue("@Role", txtUserRole);

            conn.Open();
            command.ExecuteNonQuery(); 
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = project; User Id = root; Password = dtn38hyj;");

            string Query = "insert into project.users (Username,Password,Role) values (@Username,@Password,@Role)";

            MySqlCommand command = new MySqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Username", txtUsername.Text);
            command.Parameters.AddWithValue("@Password", txtUserPassword.Text);
            command.Parameters.AddWithValue("@Role", txtUserRole.Text);

            conn.Open();
            command.ExecuteNonQuery();
        }

        private void tableView()
        {
            String query = "Select * from users";
            using (MySqlConnection conn = new MySqlConnection("Server = localhost; Database = project; User Id = root; Password = dtn38hyj;"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dtGrid.DataContext = ds.Tables[0];
                }
            }
        }

    }
}
