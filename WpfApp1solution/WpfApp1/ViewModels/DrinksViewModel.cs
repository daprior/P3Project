using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class DrinksViewModel
    {
        public TableMenuViewModel Parent { get; }
        public DrinksViewModel(TableMenuViewModel parent)
        {
            Parent = parent;
        }

    }
}
