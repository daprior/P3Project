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
using Microsoft.Win32;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

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

            tableView();
        }

        public void imgbytearray()
        {
            //Initialize a file stream to read the image file
            FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

            //Initialize a byte array with size of stream
            byte[] imgByteArr = new byte[fs.Length];

            //Read data from the file stream and put into the byte array
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

            //Close a file stream
            fs.Close();
        }


        private void AddToMenu_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = project; User Id = root; Password = dtn38hyj;");

            string Query = "insert into project.menu (name,price,img) values (@Name,@Price,@img)";


            /////////////////

            //Initialize a file stream to read the image file
            FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

            //Initialize a byte array with size of stream
            byte[] imgByteArr = new byte[fs.Length];

            //Read data from the file stream and put into the byte array
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

            //Close a file stream
            fs.Close();

            ////////////////////

            MySqlCommand command = new MySqlCommand(Query, conn);
            command.Parameters.AddWithValue("@name", txtFoodName.Text);
            command.Parameters.AddWithValue("@price", txtPrice.Text);
            command.Parameters.AddWithValue("@img", imgByteArr);

            conn.Open();
            command.ExecuteNonQuery();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = project; User Id = root; Password = dtn38hyj;");

            string Query = "delete from project.menu where (name,price) = (@Name,@Price)";

            MySqlCommand command = new MySqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Name", txtFoodName.Text);
            command.Parameters.AddWithValue("@Price", txtPrice.Text);


            conn.Open();
            command.ExecuteNonQuery();
        }


        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }

        private void tableView()
        {
            String query = "Select * from menu";
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


        DataSet ds;
        string strName, imageName;
        string constr = @"Server = localhost; Database = project; User Id = root; Password = dtn38hyj;";

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                fldlg.ShowDialog();
                {
                    strName = fldlg.SafeFileName;
                    imageName = fldlg.FileName;
                    ImageSourceConverter isc = new ImageSourceConverter();
                    image1.SetValue(System.Windows.Controls.Image.SourceProperty, isc.ConvertFromString(imageName));
                }
                fldlg = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

    }
}

