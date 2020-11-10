using MySql.Data.MySqlClient;
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
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{



    /// <summary>
    /// Interaction logic for FirstOrderView.xaml
    /// </summary>
    public partial class FirstOrderView : UserControl
    {
        public FirstOrderView()
        {
            InitializeComponent();

            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("Select * from completedorder", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            adapter.Dispose();
            con.Close();
            firstOrderGrid.ItemsSource = dt.DefaultView;

        }
    }
}
