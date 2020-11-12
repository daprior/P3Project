using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    class OrderViewModel
    {

        public List<string> Names { get; set; }

        public int UserId { get; set; }

        public void RemoveOrder()

        {
            Connection.RemoveOrder(UserId);
        }

    }
}
