using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    class KitchenViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<OrderViewModel> allOrders;

        public ObservableCollection<OrderViewModel> AllOrders
        {
            get { return allOrders; }
            set
            {
                allOrders = value;
                RaisePropertyChange();
            }
        }

        

        public KitchenViewModel()
        {

            UpdateOrders();
        }

        public void UpdateOrders()
        {
            var lookuptable = Connection.MenuLookUpTable();

            AllOrders = new ObservableCollection<OrderViewModel>();

            foreach (var item in Connection.ReadOrders())
            {
                var names = new List<string>();

                foreach (var id in item.Value)
                {
                    names.Add(lookuptable[id]);
                }

                AllOrders.Add(new OrderViewModel { UserId = item.Key, Names = names });
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
