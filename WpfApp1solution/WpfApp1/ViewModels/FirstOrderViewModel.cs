using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class FirstOrderViewModel
    {
        public KitchenForm KitchenForm { get; }
        public FirstOrderViewModel(KitchenForm kitchenForm)
        {
            KitchenForm = kitchenForm;
        }
    }
}
