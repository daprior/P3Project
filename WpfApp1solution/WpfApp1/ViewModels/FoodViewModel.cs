using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class FoodViewModel
    {
        public TableMenuViewModel Parent { get; }
        public FoodViewModel(TableMenuViewModel parent)
        {
            Parent = parent;
        }
    }
}
