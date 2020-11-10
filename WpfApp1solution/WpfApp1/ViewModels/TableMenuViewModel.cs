using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.ViewModels
{
    public class TableMenuViewModel : INotifyPropertyChanged
    {

        private DataTable ordertable;

        public event PropertyChangedEventHandler PropertyChanged;

        public DataTable OrderTable
        {
            get { return ordertable; }
            set {
                ordertable = value;
                RaisePropertyChange();
            }
        }

        

        public TableMenuViewModel()
        {
            Gridvieworder_Data();


        }

        public void Gridvieworder_Data()
        {
            string connectionstring = "SERVER= localhost; DATABASE=projectgroup;UID=root;PASSWORD=dtn38hyj;";

            var connection = new MySqlConnection(connectionstring);

            var cmd = new MySqlCommand("select id,itemname,itemprice from projectgroup.order", connection);
            connection.Open();
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            OrderTable = dt;
        }

        private void RaisePropertyChange([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
