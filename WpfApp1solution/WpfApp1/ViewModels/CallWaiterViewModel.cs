using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class CallWaiterViewModel
    {
        public KitchenForm KitchenForm { get; }
        public CallWaiterViewModel(KitchenForm kitchenForm)
        {
            KitchenForm = kitchenForm;
        }

    }
}
