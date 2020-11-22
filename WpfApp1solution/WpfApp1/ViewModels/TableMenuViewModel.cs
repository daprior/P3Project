using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class TableMenuViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<OrderItem> ordertable = new ObservableCollection<OrderItem>();
        public ObservableCollection<OrderItem> OrderTable
        {
            get { return ordertable; }
            set
            {
                ordertable = value;
                RaisePropertyChange();
            }
        }

        private DataTable menuTable;

        public DataTable MenuTable
        {
            get { return menuTable; }
            set
            {
                menuTable = value;
                RaisePropertyChange();
            }
        }

        public int Userid { get; }

        public TableMenuViewModel(int userid)
        {
            MenuTable = Connection.ReadMenu();
            Userid = userid;
        }
        public void SubmitOrder()
        {
            var orders = new List<int>();

            foreach (var item in OrderTable)
            {
                orders.Add(item.ID);
            }

            Connection.AddOrder(Userid, orders);

            OrderTable.Clear();
        }
        


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
